namespace ConsoleApp.InternetShop;

internal class Product
{
    private int _productId { get; set; }
    public string ProductName { get; set; }
    public Warehouse Warehouse { get; set; }

}

interface IProduct
{
    public Product CreateProduct();
}

interface IProductSupply
{
    public void ProductSupply(Product product);
}

