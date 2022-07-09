using static System.Console;

namespace ConsoleApp.InternetShop;

class Product : IDiscount, IRegister
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public bool IsInStock { get; set; }

    public Product(string name, int price, int quantity, bool isInStock)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        IsInStock = isInStock;
    }

    public int SetDiscount()
    {
        throw new NotImplementedException(); // Shop's discount
    }

    public void Register()
    {
        throw new NotImplementedException(); // register new product
    }

    public Product AddQuantityToExistent(int quantity)
    {
        throw new NotImplementedException();
    }

    public void AddToBasket(Basket CurrentUserBusket)
    {
        throw new NotImplementedException();
    }
}