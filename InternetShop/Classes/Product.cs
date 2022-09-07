namespace InternetShop.Classes;

internal class Product
{
    private protected decimal Price { get; set; }
    private protected int Quantity { get; set; }
    private protected int Barcode { get; init; }
    private protected string Name { get; init; }
    private protected string Type { get; init; }

}