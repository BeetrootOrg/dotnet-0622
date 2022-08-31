using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Wishlist.Contracts.Database;
using Wishlist.Domain.Database;

using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.Domain.Commands;

public class CreateWishlistCommand : IRequest<CreateWishlistCommandResult>
{
    public string Name { get; init; }
}

public class CreateWishlistCommandResult
{
    public int WishlistId { get; init; }
}

public class CreateWishlistCommandHandler : IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult>
{
    private readonly WishlistDbContext _dbContext;

    public CreateWishlistCommandHandler(WishlistDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<CreateWishlistCommandResult> Handle(CreateWishlistCommand request, CancellationToken cancellationToken)
    {
        var wishlist = new WishlistModel
        {
            Name = request.Name,
            CreatedAt = DateTime.UtcNow,
            Presents = Enumerable.Empty<Present>()
        };

        await _dbContext.AddAsync(wishlist, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new CreateWishlistCommandResult
        {
            WishlistId = wishlist.Id
        };
    }
}