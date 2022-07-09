namespace ConsoleApp.InternetShop;

class Basket
{
    public Product[] ProductsToBuy { get; set; }

    public new Receipt SellProducts()
    {
        throw new NotImplementedException();
    }
}