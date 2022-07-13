
namespace ConsoleApp.InternetShop;

class Wardrobe : IProduct
{
    public int Price { get; init; }

    public int Quantity { get; private set; }

    public int Width { get; init; }

    public int AddQuantity()
    {
        Quantity = Quantity + 1;
        return Quantity;

    }

    public Wardrobe(int price, int quantity, int width)
    {
        Price = price;
        Quantity = quantity;
        Width = width;
    }


}