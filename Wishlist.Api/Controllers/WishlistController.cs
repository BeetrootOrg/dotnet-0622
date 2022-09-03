using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Commands;

namespace Wishlist.Api.Controllers;

[Route("api/wishlist")]
public class WishlistController : ControllerBase
{
    private readonly IMediator _mediator;

    public WishlistController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPut]
    public async Task<IActionResult> CreateWishlist([FromBody] CreateWishlistRequest request,
        CancellationToken cancellationToken)
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

        return Created("http://todo.com", response);
    }
}