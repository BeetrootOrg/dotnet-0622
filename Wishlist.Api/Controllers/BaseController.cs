using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Npgsql;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Exceptions;

namespace Wishlist.Api.Controllers;

public class BaseController : ControllerBase
{
    private readonly ILogger _logger;

    protected BaseController(ILogger logger)
    {
        _logger = logger;
    }

    protected async Task<IActionResult> SafeExecute(Func<Task<IActionResult>> action,
        CancellationToken cancellationToken)
    {
        try
        {
            return await action();
        }
        catch (WishlistException we)
        {
            _logger.LogError(we, "Wishlist exception raised");

            var response = new ErrorResponse
            {
                Code = we.ErrorCode,
                Message = we.Message
            };

            return ToActionResult(response);
        }
        catch (InvalidOperationException ioe) when (ioe.InnerException is NpgsqlException)
        {
            _logger.LogError(ioe, "DB exception raised");

            var response = new ErrorResponse
            {
                Code = ErrorCode.DbFailureError,
                Message = "DB failure"
            };

            return ToActionResult(response);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Unhandled exception raised");

            var response = new ErrorResponse
            {
                Code = ErrorCode.InternalServerError,
                Message = "Unhandled error"
            };

            return ToActionResult(response);
        }
    }

    protected IActionResult ToActionResult(ErrorResponse errorResponse)
    {
        return StatusCode((int)errorResponse.Code / 100, errorResponse);
    }
}