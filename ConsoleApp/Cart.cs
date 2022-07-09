namespace ConsoleApp;

public class Cart
{
    public List<Product> CartProducts {get; init;}

    public Cart()
    {
        CartProducts = new List<Product>();
    }

    public void AddToCart(Product product)
    {
        CartProducts.Add(product);
        Console.WriteLine($"Incredible watch {product.Name} is added to your cart.");
    }

    public void PrintCart()
    {
        Console.WriteLine("Cart:");
        if (CartProducts == null || CartProducts.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Unfortunately, your cart is empty, please select products to buy!");
        }

        foreach (var Product in CartProducts)
        {
            Product.ListProduct(Product);
        }
    }
}