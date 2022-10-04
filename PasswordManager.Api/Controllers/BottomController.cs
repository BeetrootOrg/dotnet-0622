using Microsoft.AspNetCore.Mvc;

using Npgsql;

using PasswordManager.Contracts.Http;

namespace PasswordManager.Api.Controllers;

public class BottomControler : ControllerBase
{
    protected async Task<IActionResult> SafeExecute(Func<Task<IActionResult>> action, CancellationToken cancellationToken)
    {
        // try
        // {
        //     return await action();
        // }
        // catch(InvalidOperationException ioe) when (ioe.InnerException is NpgsqlException)
        // {
        //     var response = new ErrorResponse
        //     {
        //         Code = ErrorCode.DbFailureError,
        //         MessageInfo = "Database failure"
        //     };

        //     return ToActionResult(response);
        // }
        // catch(Exception)
        // {
        //     var response = new ErrorResponse
        //     {
        //         Code = ErrorCode.InternalServerError,
        //         MessageInfo = "Unhandled error"
        //     };

        //     return ToActionResult(response);
        // }
        return await action();
    }

    protected IActionResult ToActionResult(ErrorResponse errorResponse)
    {
        return StatusCode((int) errorResponse.Code / 100, errorResponse);
    }
}