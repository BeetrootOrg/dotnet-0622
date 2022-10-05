using Microsoft.AspNetCore.Mvc;

using Npgsql;

using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Exceptions;

namespace PasswordManager.Api.Controllers;

public class BottomControler : ControllerBase
{
    protected async Task<IActionResult> SafeExecute(Func<Task<IActionResult>> action, CancellationToken cancellationToken)
    {
        try
        {
            return await action();
        }
        catch(PasswordManagerException pme)
        {
            var response = new ErrorResponse
            {
                Code = pme.ErrorCode,
                MessageInfo = pme.Message
            };

            return ToActionResult(response);
        }
        catch(InvalidOperationException ioe) when (ioe.InnerException is NpgsqlException)
        {
            var response = new ErrorResponse
            {
                Code = ErrorCode.DbFailureError,
                MessageInfo = "Database failure"
            };

            return ToActionResult(response);
        }
        catch(Exception)
        {
            var response = new ErrorResponse
            {
                Code = ErrorCode.InternalServerError,
                MessageInfo = "Unhandled error"
            };

            return ToActionResult(response);
        }
    }

    protected IActionResult ToActionResult(ErrorResponse errorResponse)
    {
        return StatusCode((int)errorResponse.Code / 100, errorResponse);
    }
}