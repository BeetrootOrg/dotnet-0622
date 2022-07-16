namespace ConsoleApp.InternetShopHW;

class Receipt : IEmail
{
    public double FinalPrice { get; set; }
    public Product SelledProduct { get; set; }
    public IBuyable SelledTo { get; set; }
    public Receipt(double finalPrice, Product selledProduct, IBuyable selledTo)
    {
        FinalPrice = finalPrice;
        SelledProduct = selledProduct;
        SelledTo = selledTo;
    }

    public void ProcessEmail(string emailAddress)
    {
        System.Console.WriteLine($"Sending this receipt to {emailAddress}");
    }
}