using MediatR;

using PasswordManager.Contracts.Database;
using PasswordManager.Domain.Database;

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

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserCommandResult>
{
    private readonly PasswordManagerDbContext _dbContext;

    public RegisterUserCommandHandler(PasswordManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<RegisterUserCommandResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Name = request.UserName,
            Password = request.Password,
            Email = request.Email,
            PasswordSalt = request.PasswordSalt
        };

        await _dbContext.AddAsync(user, cancellationToken);
        await _dbContext.SaveChangesAsync();

        return new RegisterUserCommandResult
        {
            UserName = user.Name,
            Email = user.Email
        };
    }
}