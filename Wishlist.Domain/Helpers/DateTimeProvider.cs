using System;

using Wishlist.Domain.Helpers.Interfaces;

namespace Wishlist.Domain.Helpers;

internal class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.UtcNow;
}