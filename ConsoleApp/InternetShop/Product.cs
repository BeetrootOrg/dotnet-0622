namespace ConsoleApp.InternetShop;


class Product : IAddNewProd
{
    public string ProductName { get; set; }
    public ProductType ProductType { get; set; }
    public int ProductPrice { get; init; }
    public int Quantity { get; set; }


    public void ShowProduct()
    {
      System.Console.WriteLine($"Product name:{ProductName}, Product type: {ProductType}, Price:{ProductPrice}, Quantity:{Quantity}");
    }
}



interface IAddNewProd
{
    public void ShowProduct();
}

