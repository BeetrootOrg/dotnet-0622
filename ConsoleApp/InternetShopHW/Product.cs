namespace ConsoleApp.InternetShopHW;

abstract class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; init; }
    public string Category { get; init; }

    public abstract Receipt SellProduct(IBuyable customer);

    public virtual void AddQuantiny(int quantity)
    {
        Quantity +=quantity;
    }
    
}