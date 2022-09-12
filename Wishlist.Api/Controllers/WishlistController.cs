using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Commands;
using Wishlist.Domain.Queries;

namespace Wishlist.Api.Controllers;

[ApiController]
[Route("api/wishlist")]
[Produces("application/json")]
public class WishlistController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public WishlistController(IMediator mediator,
        IMapper mapper,
        ILogger<WishlistController> logger) : base(logger)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Returns wishlist by id
    /// </summary>
    /// <param name="wishlistId">Wishlist ID</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>Wishlist with presents</returns>
    /// <response code="200">Returns wishlist with all it's presents</response>
    /// <response code="404">Wishlist not found</response>
    /// <response code="500">Internal Server Error</response>
    [HttpGet("{wishlistId}")]
    [ProducesResponseType(typeof(WishlistResponse), 200)]
    [ProducesResponseType(typeof(ErrorResponse), 404)]
    [ProducesResponseType(typeof(ErrorResponse), 500)]
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
                Wishlist = _mapper.Map<Contracts.Http.Wishlist>(wishlist)
            };

            return Ok(response);
        }, cancellationToken);

    [HttpPut]
    public Task<IActionResult> CreateWishlist([FromBody] CreateWishlistRequest request,
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