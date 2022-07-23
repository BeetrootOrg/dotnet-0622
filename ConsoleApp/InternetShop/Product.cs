class Product
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Product(decimal price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }
}