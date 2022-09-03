using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Commands;
using Wishlist.Domain.Queries;

namespace Wishlist.Api.Controllers;

[Route("api/wishlist")]
public class WishlistController : BaseController
{
    private readonly IMediator _mediator;

    public WishlistController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{wishlistId}")]
    public Task<IActionResult> GetWishlist([FromRoute] int wishlistId,
        CancellationToken cancellationToken) =>
        SafeExecute(async () =>
        {
            var query = new WishlistQuery
            {
                WishlistId = wishlistId
            };

            var result = await _mediator.Send(query, cancellationToken);
            var wishlist = result.Wishlist;
            var response = new WishlistResponse
            {
                Wishlist = new Contracts.Http.Wishlist
                {
                    Id = wishlist.Id,
                    CreatedAt = wishlist.CreatedAt,
                    Name = wishlist.Name,
                    Presents = wishlist.Presents.Select(present => new Present
                    {
                        BookedAt = present.BookedAt,
                        Comment = present.Comment,
                        CreatedAt = present.CreatedAt,
                        Id = present.Id,
                        Name = present.Name
                    })
                }
            };

            return Ok(response);
        }, cancellationToken);

    [HttpPut]
    public Task<IActionResult> CreateWishlist([FromBody] CreateWishlistRequest request,
        CancellationToken cancellationToken) =>
        SafeExecute(async () =>
        {
            var command = new CreateWishlistCommand
            {
                Name = request.Name
            };

            var result = await _mediator.Send(command, cancellationToken);
            var response = new CreateWishlistResponse
            {
                Id = result.Wishlist.Id
            };

            return Created($"http://{Request.Host}/api/wishlist/{response.Id}", response);
        }, cancellationToken);
}