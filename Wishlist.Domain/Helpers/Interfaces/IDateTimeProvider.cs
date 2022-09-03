using System;

namespace Wishlist.Domain.Helpers.Interfaces;

public interface IDateTimeProvider
{
    DateTime Now { get; }
}