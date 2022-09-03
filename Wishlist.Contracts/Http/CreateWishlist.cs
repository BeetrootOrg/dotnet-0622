using System.ComponentModel.DataAnnotations;

namespace Wishlist.Contracts.Http;

public class CreateWishlistRequest
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
}

public class CreateWishlistResponse
{
    public int Id { get; set; }
}