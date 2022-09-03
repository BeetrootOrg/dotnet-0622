using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;

using Moq;

using Shouldly;

using Wishlist.Domain.Commands;
using Wishlist.Domain.Database;
using Wishlist.Domain.Helpers.Interfaces;

namespace Wishlist.UnitTests.Commands;

public class CreateWishlistCommandHandlerTests : IDisposable
{
    private readonly WishlistDbContext _dbContext;
    private readonly Mock<IDateTimeProvider> _dateTimeProvider;

    private readonly IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult> _handler;

    public CreateWishlistCommandHandlerTests()
    {
        var tempFile = Path.GetTempFileName();

        var options = new DbContextOptionsBuilder<WishlistDbContext>()
            .UseSqlite($"Data Source={tempFile};")
            .Options;

        _dbContext = new WishlistDbContext(options);
        _dbContext.Database.Migrate();

        _dateTimeProvider = new Mock<IDateTimeProvider>();

        _handler = new CreateWishlistCommandHandler(_dbContext, _dateTimeProvider.Object);
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