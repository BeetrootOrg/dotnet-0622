namespace ConsoleApp.InternetShop;
class Receipt
{
    public Buyer BuyerID { get; init; }
    public Product[] ProductList { get; set; }
    public DateTime TimePurchase { get; set; }
}