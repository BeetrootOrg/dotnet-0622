using System.ComponentModel.DataAnnotations;

namespace Wishlist.Contracts.Http;

public class CreateWishlistRequest
{
    [Required]
    [MaxLength(100)]
    public string Name { get; init; }
}

public class CreateWishlistResponse
{
    public int Id { get; init; }
}