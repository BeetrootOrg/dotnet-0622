namespace PasswordManager.Contracts.Http;

public enum ErrorCode
{
    InternalServerError = 50000,
    DbFailureError = 50001
}

public class ErrorResponse : Exception
{
    public ErrorCode Code { get; set; }
    public string MessageInfo { get; set; }
}