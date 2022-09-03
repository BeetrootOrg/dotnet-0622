using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;

using Shouldly;

using Wishlist.Contracts.Database;
using Wishlist.Contracts.Http;
using Wishlist.Domain.Database;
using Wishlist.Domain.Exceptions;
using Wishlist.Domain.Queries;
using Wishlist.UnitTests.Helpers;

using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.UnitTests.Queries;

public class WishlistQueryHandlerTests : IDisposable
{
    private readonly WishlistDbContext _dbContext;
    private readonly IRequestHandler<WishlistQuery, WishlistQueryResult> _handler;

    public WishlistQueryHandlerTests()
    {
        _dbContext = DbContextHelper.CreateTestDb();
        _handler = new WishlistQueryHandler(_dbContext);
    }

    [Fact]
    public async Task HandlerShouldReturnWishlist()
    {
        // Arrange
        var dbContext = DbContextHelper.CreateTestDb(_dbContext.Database.GetDbConnection().ConnectionString);
        var wishlist = new WishlistModel
        {
            CreatedAt = new DateTime(2005, 01, 02),
            Name = Guid.NewGuid().ToString(),
            Presents = new[]
            {
                new Present
                {
                    Name = Guid.NewGuid().ToString(),
                    BookedAt = new DateTime(2005, 01, 03),
                    Comment = Guid.NewGuid().ToString(),
                    CreatedAt = new DateTime(2005, 01, 01)
                },
                new Present
                {
                    Name = Guid.NewGuid().ToString(),
                    BookedAt = null,
                    Comment = Guid.NewGuid().ToString(),
                    CreatedAt = new DateTime(2005, 01, 01)
                }
            }
        };

        await dbContext.AddAsync(wishlist);
        await dbContext.SaveChangesAsync();

        var query = new WishlistQuery
        {
            WishlistId = wishlist.Id
        };

        // Act
        var result = await _handler.Handle(query, CancellationToken.None);

        // Assert
        result.ShouldNotBeNull();
        result.Wishlist.ShouldNotBeNull();
        result.Wishlist.Id.ShouldBe(wishlist.Id);
        result.Wishlist.Name.ShouldBe(wishlist.Name);
        result.Wishlist.CreatedAt.ShouldBe(wishlist.CreatedAt);
        result.Wishlist.Presents.ShouldNotBeEmpty();
        result.Wishlist.Presents.Count().ShouldBe(wishlist.Presents.Count());

        foreach (var present in result.Wishlist.Presents)
        {
            var expectedPresent = wishlist.Presents.Single(p => p.Id == present.Id);

            present.BookedAt.ShouldBe(expectedPresent.BookedAt);
            present.Comment.ShouldBe(expectedPresent.Comment);
            present.CreatedAt.ShouldBe(expectedPresent.CreatedAt);
            present.Name.ShouldBe(expectedPresent.Name);
            present.WishlistId.ShouldBe(wishlist.Id);
        }
    }

    [Fact]
    public async Task HandleShouldThrowExceptionIfNoWishlist()
    {
        // Arrange
        var wishlistId = -1;
        var query = new WishlistQuery
        {
            WishlistId = wishlistId
        };

        try
        {
            // Act
            await _handler.Handle(query, CancellationToken.None);
        }
        catch (WishlistException we) when (we.ErrorCode == ErrorCode.WishlistNotFound
            && we.Message == $"Wishlist {wishlistId} not found")
        {
            // Arrange
            // ignore
        }
    }

    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
    }
}