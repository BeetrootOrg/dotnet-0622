using MediatR;

using Microsoft.Extensions.Logging;

using PasswordManager.Contracts.Database;
using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Base;
using PasswordManager.Domain.Database;
using PasswordManager.Domain.Exceptions;

namespace PasswordManager.Domain.Commands;

public class RegisterUserCommand : IRequest<RegisterUserCommandResult>
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PasswordSalt { get; set; }
}

public class RegisterUserCommandResult
{
    public string UserName { get; set; }
    public string Email { get; set; }
}

public class RegisterUserCommandHandler : BaseHandler<RegisterUserCommand, RegisterUserCommandResult>
{
    private readonly PasswordManagerDbContext _dbContext;
    private readonly ILogger<RegisterUserCommandHandler> _logger;

    public RegisterUserCommandHandler(PasswordManagerDbContext dbContext, 
        ILogger<RegisterUserCommandHandler> logger) : base(logger)
    {
        _dbContext = dbContext;
    }

    protected override async Task<RegisterUserCommandResult> HandleInternal(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Name = request.UserName,
            Password = request.Password,
            Email = request.Email,
            PasswordSalt = request.PasswordSalt
        };

        var findUser = _dbContext.Users.SingleOrDefault(user => user.Email == request.Email);

        if(findUser != null)
        {
            throw new PasswordManagerException(ErrorCode.UserAlreadyExisted, "User with this email is already existed");
        }
        await _dbContext.AddAsync(user, cancellationToken);
        await _dbContext.SaveChangesAsync();

        return new RegisterUserCommandResult
        {
            UserName = user.Name,
            Email = user.Email
        };
    }
}