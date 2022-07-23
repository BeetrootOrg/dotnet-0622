class Stock : IProductManagement
{
    private Product[]? Products { get; set; }
    public Stock(Product[] products)
    {
        Products = products;
    }
    public int AddQuantity()
    {
        throw new NotImplementedException();
    }

    public object RegisterNewProduct()
    {
        throw new NotImplementedException();
    }

    public void SellProduct()
    {
        throw new NotImplementedException();
    }
}