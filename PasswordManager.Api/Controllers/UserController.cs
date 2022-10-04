using System.Security.Cryptography;
using System.Text;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Commands;

namespace PasswordManager.Api.Controllers;

public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost, Route("register")]
    public async Task<IActionResult> Register(UserDTO request, CancellationToken cancellationToken)
    {
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
    }
}