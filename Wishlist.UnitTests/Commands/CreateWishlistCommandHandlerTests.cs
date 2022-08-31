using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;

using Shouldly;

using Wishlist.Domain.Commands;
using Wishlist.Domain.Database;

namespace Wishlist.UnitTests.Commands;

public class CreateWishlistCommandHandlerTests : IDisposable
{
    private readonly WishlistDbContext _dbContext;

    private readonly IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult> _handler;

    public CreateWishlistCommandHandlerTests()
    {
        var tempFile = Path.GetTempFileName();

        var options = new DbContextOptionsBuilder<WishlistDbContext>()
            .UseSqlite($"Data Source={tempFile};")
            .Options;

        _dbContext = new WishlistDbContext(options);
        _dbContext.Database.Migrate();

        _handler = new CreateWishlistCommandHandler(_dbContext);
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

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        result.ShouldNotBeNull();
        result.WishlistId.ShouldBeGreaterThan(0);
    }

    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
    }
}