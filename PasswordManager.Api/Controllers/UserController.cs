using System.Security.Cryptography;
using System.Text;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Npgsql;

using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Commands;

namespace PasswordManager.Api.Controllers;

//[Route("api/user")]
public class UserController : BottomControler
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator, ILogger<UserController> logger) : base(logger)
    {
        _mediator = mediator;
    }

    [HttpPost, Route("register")]
    public Task<IActionResult> Register(UserDTO request, CancellationToken cancellationToken)
    {
        return SafeExecute(async () => 
        {
            if(!ModelState.IsValid)
            {
                return ToActionResult(new ErrorResponse
                {
                    Code = ErrorCode.BadRequest,
                    MessageInfo = "Invalid request"
                });
            }
            var passwordSalt = Convert.ToBase64String(RandomNumberGenerator.GetBytes(256));
            var command = new RegisterUserCommand
            {
                UserName = request.UserName,
                Email = request.Email,
                PasswordSalt = passwordSalt,
                Password = Convert.ToBase64String(Rfc2898DeriveBytes.Pbkdf2(
                    Encoding.UTF8.GetBytes(request.Password), Encoding.UTF8.GetBytes(passwordSalt),5000,HashAlgorithmName.SHA256, 256))
            };

            var result = await _mediator.Send(command, cancellationToken);
            var response = new UserDTOResponse
            {
                UserName = result.UserName,
                Email = result.Email
            };

            return Created("http://todo.com",response);
        }, cancellationToken);
    }

    [HttpPost, Route("login")]
    public Task<IActionResult> Login(UserDTO request, CancellationToken cancellationToken)
    {
        return SafeExecute(async () => 
        {
            var command = new LoginUserCommand
            {
                UserName = request.UserName,
                Email = request.Email,
                Password = request.Password
            };
            var result = await _mediator.Send(command, cancellationToken);
            var response = new Token
            {
                JwtToken = result.Token
            };
            return Ok(new { Token = result.Token });
        },cancellationToken);
    }
}