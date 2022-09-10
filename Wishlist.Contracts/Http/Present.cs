using System;

namespace Wishlist.Contracts.Http;

public class Present
{
    public int Id { get; init; }

    public string Name { get; init; }

    public string Comment { get; init; }

    public DateTime CreatedAt { get; init; }

    public DateTime? BookedAt { get; init; }

    public bool Booked => BookedAt != null;
}