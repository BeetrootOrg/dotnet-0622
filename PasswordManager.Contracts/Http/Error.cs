namespace PasswordManager.Contracts.Http;

public enum ErrorCode
{
    BadRequest = 40000,
    UserNotFound = 40401,
    UserAlreadyExisted = 40402,
    IncorrectEmailOrPassword = 40403,
    UserHasNotBeenFound = 40404,
    InternalServerError = 50000,
    DbFailureError = 50001
}

public class ErrorResponse : Exception
{
    public ErrorCode Code { get; set; }
    public string MessageInfo { get; set; }
}