using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using Moq;

using Shouldly;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Commands;
using Wishlist.Domain.Exceptions;
using Wishlist.Domain.Helpers.Interfaces;
using Wishlist.UnitTests.Base;
using Wishlist.UnitTests.Helpers;

using Present = Wishlist.Contracts.Database.Present;
using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.UnitTests.Commands;

public class CreatePresentCommandHandlerTests : BaseHandlerTest<CreatePresentCommand, CreatePresentCommandResult>
{
    private readonly Mock<IDateTimeProvider> _dateTimeProvider = new Mock<IDateTimeProvider>();

    public CreatePresentCommandHandlerTests() : base()
    {
    }

    protected override IRequestHandler<CreatePresentCommand, CreatePresentCommandResult> CreateHandler()
    {
        return new CreatePresentCommandHandler(DbContext,
            _dateTimeProvider.Object,
            new Mock<ILogger<CreatePresentCommandHandler>>().Object);
    }

    [Fact]
    public async Task HandleShouldAddPresentToWishlist()
    {
        // Arrange
        var dbContext = DbContextHelper.CreateTestDb(DbContext.Database.GetDbConnection().ConnectionString);
        var wishlist = new WishlistModel
        {
            Name = Guid.NewGuid().ToString(),
            CreatedAt = DateTime.UtcNow,
            Presents = new List<Present>
            {
                new Present
                {
                    BookedAt = DateTime.UtcNow,
                    Comment = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.UtcNow,
                    Name = Guid.NewGuid().ToString(),
                }
            }
        };

        await dbContext.Wishlists.AddAsync(wishlist);
        await dbContext.SaveChangesAsync();

        var command = new CreatePresentCommand
        {
            Comment = Guid.NewGuid().ToString(),
            Name = Guid.NewGuid().ToString(),
            WishlistId = wishlist.Id
        };

        var now = DateTime.UtcNow.Subtract(TimeSpan.FromMinutes(42));
        _dateTimeProvider.SetupGet(x => x.Now).Returns(now);

        // Act
        var result = await Handler.Handle(command, CancellationToken.None);
        var resultWishlist = await DbContext.Wishlists
            .Include(w => w.Presents)
            .SingleOrDefaultAsync(w => w.Id == wishlist.Id);

        // Assert
        result.Present.ShouldNotBeNull();
        result.Present.Id.ShouldBeGreaterThan(0);
        result.Present.Name.ShouldBe(command.Name);
        result.Present.Comment.ShouldBe(command.Comment);
        result.Present.CreatedAt.ShouldBe(now);
        result.Present.BookedAt.ShouldBeNull();
        result.Present.WishlistId.ShouldBe(command.WishlistId);
        resultWishlist.Presents.Count.ShouldBe(wishlist.Presents.Count + 1);
    }

    [Fact]
    public async Task HandleShouldThrowExceptionIfNoWishlist()
    {
        // Arrange
        var wishlistId = -1;
        var command = new CreatePresentCommand
        {
            Comment = Guid.NewGuid().ToString(),
            Name = Guid.NewGuid().ToString(),
            WishlistId = wishlistId
        };

        try
        {
            // Act
            await Handler.Handle(command, CancellationToken.None);
        }
        catch (WishlistException we) when (we.ErrorCode == ErrorCode.WishlistNotFound &&
            we.Message == $"Wishlist {wishlistId} not found")
        {
            // Assert
            // ignore
        }
    }
}