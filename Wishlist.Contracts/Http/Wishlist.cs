using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wishlist.Contracts.Http;

public class Wishlist
{
    public int Id { get; init; }

    [Required]
    [MaxLength(100)]
    public string Name { get; init; }

    public DateTime CreatedAt { get; init; }

    public virtual IEnumerable<Present> Presents { get; init; }
}