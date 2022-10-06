using Microsoft.AspNetCore.Mvc;

using Npgsql;

using PasswordManager.Contracts.Http;
using PasswordManager.Domain.Exceptions;

namespace PasswordManager.Api.Controllers;

public class BottomControler : ControllerBase
{
    private readonly ILogger _logger;

    protected BottomControler(ILogger logger)
    {
        _logger = logger;
    }

    protected async Task<IActionResult> SafeExecute(Func<Task<IActionResult>> action, CancellationToken cancellationToken)
    {
        try
        {
            return await action();
        }
        catch(PasswordManagerException pme)
        {
            _logger.LogError(pme, "PasswordManager exception raised");

            var response = new ErrorResponse
            {
                Code = pme.ErrorCode,
                MessageInfo = pme.Message
            };

            return ToActionResult(response);
        }
        catch(InvalidOperationException ioe) when (ioe.InnerException is NpgsqlException)
        {
            _logger.LogError(ioe, "DB exception raised");

            var response = new ErrorResponse
            {
                Code = ErrorCode.DbFailureError,
                MessageInfo = "Database failure"
            };

            return ToActionResult(response);
        }
        catch(Exception e)
        {
            _logger.LogError(e, "Unhandled exception raised");

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