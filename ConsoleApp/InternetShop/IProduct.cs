namespace ConsoleApp.InternetShop;

interface IProduct
{
    int Price { get; init; }

    int Quantity { get; }

    int AddQuantity ();

    Receipt Sell (Buyer buyer);

}


