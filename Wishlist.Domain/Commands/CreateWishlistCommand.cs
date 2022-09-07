using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.Extensions.Logging;

using Wishlist.Contracts.Database;
using Wishlist.Domain.Base;
using Wishlist.Domain.Database;
using Wishlist.Domain.Helpers.Interfaces;

using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.Domain.Commands;

public class CreateWishlistCommand : IRequest<CreateWishlistCommandResult>
{
    public string Name { get; init; }
}

public class CreateWishlistCommandResult
{
    public WishlistModel Wishlist { get; init; }
}

internal class CreateWishlistCommandHandler : BaseHandler<CreateWishlistCommand, CreateWishlistCommandResult>
{
    private readonly WishlistDbContext _dbContext;
    private readonly IDateTimeProvider _dateTimeProvider;

    public CreateWishlistCommandHandler(WishlistDbContext dbContext,
        IDateTimeProvider dateTimeProvider,
        ILogger<CreateWishlistCommandHandler> logger) : base(logger)
    {
        _dbContext = dbContext;
        _dateTimeProvider = dateTimeProvider;
    }

    protected override async Task<CreateWishlistCommandResult> HandleInternal(CreateWishlistCommand request,
        CancellationToken cancellationToken)
    {
        var wishlist = new WishlistModel
        {
            Name = request.Name,
            CreatedAt = _dateTimeProvider.Now,
            Presents = Enumerable.Empty<Present>()
        };

        await _dbContext.AddAsync(wishlist, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new CreateWishlistCommandResult
        {
            Wishlist = wishlist
        };
    }
}