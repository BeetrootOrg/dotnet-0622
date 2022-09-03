using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Database;
using Wishlist.Domain.Exceptions;

using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.Domain.Queries;

public class WishlistQuery : IRequest<WishlistQueryResult>
{
    public int WishlistId { get; init; }
}

public class WishlistQueryResult
{
    public WishlistModel Wishlist { get; set; }
}

public class WishlistQueryHandler : IRequestHandler<WishlistQuery, WishlistQueryResult>
{
    private readonly WishlistDbContext _dbContext;

    public WishlistQueryHandler(WishlistDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<WishlistQueryResult> Handle(WishlistQuery request, CancellationToken cancellationToken)
    {
        var wishlistId = request.WishlistId;

        var wishlist = await _dbContext.Wishlists
            .Include(w => w.Presents)
            .SingleOrDefaultAsync(w => w.Id == wishlistId, cancellationToken);

        return wishlist == null
            ? throw new WishlistException(ErrorCode.WishlistNotFound, $"Wishlist {wishlistId} not found")
            : new WishlistQueryResult
            {
                Wishlist = wishlist
            };
    }
}