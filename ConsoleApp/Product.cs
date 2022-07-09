namespace ConsoleApp;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public static void ListProduct(Product product)
    {
        Console.WriteLine($"#: {product.Name} \t#: {product.Description} \t#: {product.Price}");
    }
}
