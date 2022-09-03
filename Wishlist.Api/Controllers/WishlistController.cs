using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Npgsql;

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
        try
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
        catch (InvalidOperationException ioe) when (ioe.InnerException is NpgsqlException)
        {
            var response = new ErrorResponse
            {
                Code = ErrorCode.DbFailureError,
                Message = "DB failure"
            };

            return ToActionResult(response);
        }
        catch (Exception)
        {
            var response = new ErrorResponse
            {
                Code = ErrorCode.InternalServerError,
                Message = "Unhandled error"
            };

            return ToActionResult(response);
        }
    }

    private IActionResult ToActionResult(ErrorResponse errorResponse)
    {
        return StatusCode((int)errorResponse.Code / 100, errorResponse);
    }
}