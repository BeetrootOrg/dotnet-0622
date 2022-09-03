using System;
using System.ComponentModel.DataAnnotations;

namespace Wishlist.Contracts.Http;

public class Present
{
    public int Id { get; init; }

    [Required]
    [MaxLength(100)]
    public string Name { get; init; }

    [Required]
    [MaxLength(500)]
    public string Comment { get; init; }

    public DateTime CreatedAt { get; init; }

    public DateTime? BookedAt { get; init; }

    public bool Booked => BookedAt != null;
}