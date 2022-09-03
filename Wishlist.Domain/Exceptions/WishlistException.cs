using System;

using Wishlist.Contracts.Http;

namespace Wishlist.Domain.Exceptions;

public class WishlistException : Exception
{
    public ErrorCode ErrorCode { get; }

    public WishlistException(ErrorCode errorCode) : this(errorCode, null)
    {
    }

    public WishlistException(ErrorCode errorCode, string message) : base(message)
    {
        ErrorCode = errorCode;
    }
}