using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Wishlist.Contracts.Database;
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

public class CreateWishlistCommandHandler : IRequestHandler<CreateWishlistCommand, CreateWishlistCommandResult>
{
    private readonly WishlistDbContext _dbContext;
    private readonly IDateTimeProvider _dateTimeProvider;

    public CreateWishlistCommandHandler(WishlistDbContext dbContext, IDateTimeProvider dateTimeProvider)
    {
        _dbContext = dbContext;
        _dateTimeProvider = dateTimeProvider;
    }

    public async Task<CreateWishlistCommandResult> Handle(CreateWishlistCommand request, CancellationToken cancellationToken)
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