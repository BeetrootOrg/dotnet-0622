using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.Extensions.Logging;

using Moq;

using Shouldly;

using Wishlist.Domain.Commands;
using Wishlist.Domain.Helpers.Interfaces;
using Wishlist.UnitTests.Base;

namespace Wishlist.UnitTests.Commands;

public class CreateWishlistCommandHandlerTests : BaseHandlerTest<CreateWishlistCommand, CreateWishlistCommandResult>
{
    private readonly Mock<IDateTimeProvider> _dateTimeProvider = new Mock<IDateTimeProvider>();

    public CreateWishlistCommandHandlerTests() : base()
    {
    }

    protected override IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult> CreateHandler()
    {
        return new CreateWishlistCommandHandler(DbContext,
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
        var result = await Handler.Handle(command, CancellationToken.None);

        // Assert
        result.ShouldNotBeNull();
        result.Wishlist.ShouldNotBeNull();
        result.Wishlist.Id.ShouldBeGreaterThan(0);
        result.Wishlist.CreatedAt.ShouldBe(now);
        result.Wishlist.Name.ShouldBe(wishlistName);
        result.Wishlist.Presents.ShouldBeEmpty();
    }
}