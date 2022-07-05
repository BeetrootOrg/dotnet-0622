namespace ConsoleApp;

public class Cart
{
    public List<Product> CartProducts {get; init;}

    public Cart()
    {
        CartProducts = new List<Product>();
    }

    public void AddToCart(Product Product)
    {
        CartProducts.Add(Product);
        Console.WriteLine ($"Item {Product.Name} was added to cart");
    }

    public void ShowCart()
    {
        Console.WriteLine("----------Shopping Cart----------");
        if (CartProducts == null || CartProducts.Count == 0)
            Console.WriteLine ("Your Cart is empty, Sir! Please add some products and buy them!");

        foreach (var Product in CartProducts)
            Product.ShowProduct(Product);
    }
}

