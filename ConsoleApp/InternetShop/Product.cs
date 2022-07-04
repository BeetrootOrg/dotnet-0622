namespace ConsoleApp.InternetShop;
class Product : IAddNewProd
{
    public string ProductName { get; set; }
    public ProductType ProductType { get; set; }
    public int ProductPrice { get; init; }
     public int Quantity { get; set; }

    public void AddNewProduct()
    {
        throw new NotImplementedException();
    }
}

interface IAddNewProd
{
    public void AddNewProduct();
}