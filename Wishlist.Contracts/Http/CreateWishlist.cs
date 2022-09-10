namespace Wishlist.Contracts.Http;

public class CreateWishlistRequest
{
    public string Name { get; init; }
}

public class CreateWishlistResponse
{
    public int Id { get; init; }
}