namespace ConsoleApp.InternetShopHW;

class Worker : Person, IBuyable
{
    public void Buy(Product productToBuy)
    {
        System.Console.WriteLine("At least I have an employee discount");
        System.Console.WriteLine($"The final price is {productToBuy.Price * 0.7}");
        productToBuy.SellProduct(this);
    }

    public override void GetWishOfLife()
    {
        System.Console.WriteLine("I want to get a promotion. I worked hard this year");
    }
}