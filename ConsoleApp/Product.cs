namespace Shop;

internal class Product
{
    public string Name { get; init; }
    public double Price { get; set; }
    public int Quantity { get; set; }

}

interface IProduct
{
    public Product CreateProduct();
}
interface IResupply
{
    public Product AddQuantity();
}