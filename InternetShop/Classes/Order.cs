namespace InternetShop.Classes;

internal class Order : IOrder
{
    private protected string IDNumber { get; init; }
    private protected DateTime Date { get; init; }
    private protected string Status { get; set; }
    private protected Buyer Buyer { get; init; }
    private protected Product[] Products { get; init; }

    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void RemoveProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void ClearProducts()
    {
        throw new NotImplementedException();
    }

}