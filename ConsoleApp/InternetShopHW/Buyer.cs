namespace ConsoleApp.InternetShopHW;

class Buyer : Person, IBuyable, IEmail
{
    public void Buy(Product productToBuy)
    {
        System.Console.WriteLine("Do not even have a discount...");
        productToBuy.SellProduct(this);
    }

    public override void GetWishOfLife()
    {
        System.Console.WriteLine("I want more money to buy this sofa!");
    }

    public void ProcessEmail(string emailAddress)
    {
        System.Console.WriteLine($"Confirming Email Adress {emailAddress}...");
    }
}