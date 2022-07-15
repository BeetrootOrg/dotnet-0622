namespace ConsoleApp.Internetshop;

class Seller
{
    public string SallerName { get; init; }
    public int SellerId { get; init; }

    public void NewSeller()
    {
        System.Console.WriteLine("New Seller added...");
    }

}