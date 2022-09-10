using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Base;
using Wishlist.Domain.Database;
using Wishlist.Domain.Exceptions;
using Wishlist.Domain.Helpers.Interfaces;

using Present = Wishlist.Contracts.Database.Present;

namespace Wishlist.Domain.Commands;

public class CreatePresentCommand : IRequest<CreatePresentCommandResult>
{
    public string Name { get; init; }
    public string Comment { get; init; }
    public int WishlistId { get; init; }
}

public class CreatePresentCommandResult
{
    public Present Present { get; set; }
}

internal class CreatePresentCommandHandler : BaseHandler<CreatePresentCommand, CreatePresentCommandResult>
{
    private readonly WishlistDbContext _dbContext;
    private readonly IDateTimeProvider _dateTimeProvider;

    public CreatePresentCommandHandler(WishlistDbContext dbContext,
        IDateTimeProvider dateTimeProvider,
        ILogger<CreatePresentCommandHandler> logger) : base(logger)
    {
        _dbContext = dbContext;
        _dateTimeProvider = dateTimeProvider;
    }

    protected override async Task<CreatePresentCommandResult> HandleInternal(CreatePresentCommand request,
        CancellationToken cancellationToken)
    {
        var wishlistId = request.WishlistId;

        var wishlist = await _dbContext.Wishlists
            .SingleOrDefaultAsync(w => w.Id == wishlistId, cancellationToken);

        if (wishlist == null)
        {
            throw new WishlistException(ErrorCode.WishlistNotFound, $"Wishlist {wishlistId} not found");
        }

        var present = new Present
        {
            Comment = request.Comment,
            CreatedAt = _dateTimeProvider.Now,
            Name = request.Name,
            WishlistId = wishlistId
        };

        await _dbContext.Presents.AddAsync(present, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new CreatePresentCommandResult
        {
            Present = present
        };
    }
}