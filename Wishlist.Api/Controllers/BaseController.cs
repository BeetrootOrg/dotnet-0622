using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Npgsql;

using Wishlist.Contracts.Http;
using Wishlist.Domain.Exceptions;

namespace Wishlist.Api.Controllers;

public class BaseController : ControllerBase
{
    protected async Task<IActionResult> SafeExecute(Func<Task<IActionResult>> action,
        CancellationToken cancellationToken)
    {
        try
        {
            return await action();
        }
        catch (WishlistException we)
        {
            var response = new ErrorResponse
            {
                Code = we.ErrorCode,
                Message = we.Message
            };

            return ToActionResult(response);
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

    protected IActionResult ToActionResult(ErrorResponse errorResponse)
    {
        return StatusCode((int)errorResponse.Code / 100, errorResponse);
    }
}