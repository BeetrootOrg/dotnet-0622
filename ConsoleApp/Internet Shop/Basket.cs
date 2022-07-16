namespace ConsoleApp.InternetShop;

class Basket
{
    public List<Product> ProductsToBuy { get; set; } = new List<Product>();

    public Receipt SellProducts(Employee cashier, Customer buyer)
    {
        return new Receipt(cashier, buyer, ProductsToBuy);
    }
}
