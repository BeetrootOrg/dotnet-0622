namespace ConsoleApp.InternetShop;
class Receipt : ICreateNewReceipt
{
    public string BuyerID { get; set; }
    public Product[] ProductList { get; set; }
    public DateTime TimePurchase { get; set; }

    public void CreateNewReceipt()
    {
        throw new NotImplementedException();
    }
}

interface ICreateNewReceipt
{
    public void CreateNewReceipt();
}