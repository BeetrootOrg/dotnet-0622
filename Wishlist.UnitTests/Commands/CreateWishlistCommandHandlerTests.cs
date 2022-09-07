using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.Extensions.Logging;

using Moq;

using Shouldly;

using Wishlist.Domain.Commands;
using Wishlist.Domain.Database;
using Wishlist.Domain.Helpers.Interfaces;
using Wishlist.UnitTests.Helpers;

namespace Wishlist.UnitTests.Commands;

public class CreateWishlistCommandHandlerTests : IDisposable
{
    private readonly WishlistDbContext _dbContext;
    private readonly Mock<IDateTimeProvider> _dateTimeProvider;

    private readonly IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult> _handler;

    public CreateWishlistCommandHandlerTests()
    {
        _dbContext = DbContextHelper.CreateTestDb();
        _dateTimeProvider = new Mock<IDateTimeProvider>();

        _handler = new CreateWishlistCommandHandler(_dbContext,
            _dateTimeProvider.Object,
            new Mock<ILogger<CreateWishlistCommandHandler>>().Object);
    }

    [Fact]
    public async Task HandleShouldCreateEmptyWishlist()
    {
        // Arrange
        var wishlistName = Guid.NewGuid().ToString();
        var command = new CreateWishlistCommand
        {
            Name = wishlistName
        };

        var now = DateTime.UtcNow;
        _dateTimeProvider.SetupGet(x => x.Now).Returns(now);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.ShouldNotBeNull();
        result.Wishlist.ShouldNotBeNull();
        result.Wishlist.Id.ShouldBeGreaterThan(0);
        result.Wishlist.CreatedAt.ShouldBe(now);
        result.Wishlist.Name.ShouldBe(wishlistName);
        result.Wishlist.Presents.ShouldBeEmpty();
    }

    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
    }
}