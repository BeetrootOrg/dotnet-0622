using MediatR;

using Microsoft.EntityFrameworkCore;

using PasswordManager.Domain.Commands;
using PasswordManager.Domain.Database;

using Shouldly;

namespace PasswordManager.UnitTests.Commands;

public class RegisterUserCommandHandlerTests
{
    private readonly PasswordManagerDbContext _dbContext;
    private readonly IRequestHandler<RegisterUserCommand, RegisterUserCommandResult> _handler;
    public RegisterUserCommandHandlerTests()
    {
        var tempFile = Path.GetTempFileName();
        var options = new DbContextOptionsBuilder<PasswordManagerDbContext>().UseSqlite($"Data Source={tempFile};").Options;

        _dbContext = new PasswordManagerDbContext(options);
        _dbContext.Database.Migrate();

        _handler = new RegisterUserCommandHandler(_dbContext);
    }

    [Fact]
    public async Task HandleShouldRegisterNewUser()
    {
        //Arrange
        var userName = Guid.NewGuid().ToString();
        var password = Guid.NewGuid().ToString();
        var email = Guid.NewGuid().ToString();
        var passwordSalt = Guid.NewGuid().ToString();
        var command = new RegisterUserCommand
        {
            UserName = userName,
            Password = password,
            Email = email,
            PasswordSalt = passwordSalt
        };

        //Act
        var result = await _handler.Handle(command, CancellationToken.None);

        //Assert
        result.ShouldNotBeNull();
        result.Id.ShouldBeGreaterThan(0);
    }
}