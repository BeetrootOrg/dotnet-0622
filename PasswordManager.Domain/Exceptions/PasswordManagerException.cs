using PasswordManager.Contracts.Http;

namespace PasswordManager.Domain.Exceptions;

public class PasswordManagerException : Exception
{
    public ErrorCode ErrorCode { get; set; }

    public PasswordManagerException(ErrorCode errorCode) : this(errorCode, null)
    {
    }

    public PasswordManagerException(ErrorCode errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
}