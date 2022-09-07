using System;

namespace Wishlist.Domain.Helpers.Interfaces;

internal interface IDateTimeProvider
{
    DateTime Now { get; }
}