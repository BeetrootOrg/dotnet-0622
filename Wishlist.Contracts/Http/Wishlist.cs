using System;
using System.Collections.Generic;

namespace Wishlist.Contracts.Http;

public class Wishlist
{
    public int Id { get; init; }

    public string Name { get; init; }

    public DateTime CreatedAt { get; init; }

    public virtual IEnumerable<Present> Presents { get; init; }
}