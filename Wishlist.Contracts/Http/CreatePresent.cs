namespace Wishlist.Contracts.Http;

public class CreatePresentRequest
{
    public string Name { get; init; }
    public string Comment { get; init; }
    public int WishlistId { get; init; }
}

public class CreatePresentResponse
{
    public int Id { get; init; }
}