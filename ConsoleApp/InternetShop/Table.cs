namespace ConsoleApp.InternetShop;

class Table : IProduct
{
    public int Price { get; init; }
    public int Quantity { get; private set; }
    public int Height { get; init; }

        public int AddQuantity()
    {
        Quantity = Quantity + 2;
        return Quantity;

    }

    public Table(int price, int quantity, int height)
    {
        Price = price;
        Quantity = quantity;
        Height = height;
    }



}