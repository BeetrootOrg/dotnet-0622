using System;

using Wishlist.Domain.Helpers.Interfaces;

namespace Wishlist.Domain.Helpers;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.UtcNow;
}