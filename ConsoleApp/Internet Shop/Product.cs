using static System.Console;

namespace ConsoleApp.InternetShop;

class Product : IDiscount
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsInStock { get; set; }

    public Product(string name, decimal price, int quantity, bool isInStock)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        IsInStock = isInStock;
    }

    public decimal CalculateDiscount(int shopDiscount)
    {
        decimal amountOfDiscount;
        amountOfDiscount = Price * 100 / shopDiscount;
        return Price - amountOfDiscount;
    }

    public Product AddQuantityToExistent(int quantityToAdd)
    {
        Quantity += quantityToAdd;
        return this;
    }

    public void AddToBasket(Basket currentUserBusket)
    {
        currentUserBusket.ProductsToBuy.Add(this);
    }

    public void AddToWishlist(WishList currentUserWishlist)
    {
        currentUserWishlist.LikedProducts.Add(this);
    }
}