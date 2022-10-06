using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

using MediatR;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

using PasswordManager.Contracts.Database;
using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Base;
using PasswordManager.Domain.Database;
using PasswordManager.Domain.Exceptions;

namespace PasswordManager.Domain.Commands;

public class LoginUserCommand : IRequest<LoginUserCommandResult>
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PasswordSalt { get; set; }
}

public class LoginUserCommandResult
{
    public string Token { get; set; }
}

public class LoginUserCommandhandler : BaseHandler<LoginUserCommand, LoginUserCommandResult>
{
    private readonly PasswordManagerDbContext _dbContext;
    private readonly IConfiguration _configuration;
    private readonly ILogger<LoginUserCommandhandler> _logger;

    public LoginUserCommandhandler(PasswordManagerDbContext dbContext, 
        IConfiguration configuration, ILogger<LoginUserCommandhandler> logger) : base(logger)
    {
        _dbContext = dbContext;
        _configuration = configuration;
    }

    protected override Task<LoginUserCommandResult> HandleInternal(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Name = request.UserName,
            Email = request.Email,
            Password = request.Password
        };

        var findUser = _dbContext.Users.SingleOrDefault(user => user.Email == request.Email && user.Name == request.UserName);
        if(findUser == null)
        {
            throw new PasswordManagerException(ErrorCode.UserHasNotBeenFound, "User has not been found");
        }
        var compare = Convert.ToBase64String(Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(user.Password), Encoding.UTF8.GetBytes(findUser.PasswordSalt), 
                5000, HashAlgorithmName.SHA256, 256));

        if(compare != findUser.Password)
        {
            throw new PasswordManagerException(ErrorCode.IncorrectEmailOrPassword, "Incorrect email or password");
        }

        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var tokenOptions = new JwtSecurityToken(
            issuer: "qwerty",
            audience: "http://localhost:5118",
            claims: new List<Claim>(),
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: signinCredentials
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        return Task.FromResult(new LoginUserCommandResult
        {
            Token = tokenString
        });
    }
}