using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using Moq;

using PasswordManager.Domain.Commands;
using PasswordManager.Domain.Database;
using PasswordManager.UnitTests.Helpers;

using Shouldly;

namespace PasswordManager.UnitTests.Commands;

public class RegisterUserCommandHandlerTests : IDisposable
{
    private readonly PasswordManagerDbContext _dbContext;
    //private readonly ILogger<RegisterUserCommandHandler> _logger;
    private readonly IRequestHandler<RegisterUserCommand, RegisterUserCommandResult> _handler;
    public RegisterUserCommandHandlerTests()
    {
        _dbContext = DbContextHelper.CreateDbContext();
        _handler = new RegisterUserCommandHandler(_dbContext, new Mock<ILogger<RegisterUserCommandHandler>>().Object);
    }

    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
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
        result.Email.ShouldBe(email);
        result.UserName.ShouldBe(userName);
    }
}