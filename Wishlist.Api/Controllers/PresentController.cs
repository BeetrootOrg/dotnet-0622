using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Commands;

namespace Wishlist.Api.Controllers;

[Route("api/present")]
public class PresentController : BaseController
{
    private readonly IMediator _mediator;

    public PresentController(IMediator mediator, ILogger<PresentController> logger) : base(logger)
    {
        _mediator = mediator;
    }

    [HttpPut]
    public Task<IActionResult> CreatePresent([FromBody] CreatePresentRequest request,
        CancellationToken cancellationToken) =>
        SafeExecute(async () =>
        {
            if (!ModelState.IsValid)
            {
                return ToActionResult(new ErrorResponse
                {
                    Code = ErrorCode.BadRequest,
                    Message = "invalid request"
                });
            }

            var command = new CreatePresentCommand
            {
                Name = request.Name,
                Comment = request.Comment,
                WishlistId = request.WishlistId
            };

            var result = await _mediator.Send(command, cancellationToken);
            var response = new CreateWishlistResponse
            {
                Id = result.Present.Id
            };

            return Created($"http://{Request.Host}/api/present/{response.Id}", response);
        }, cancellationToken);
}