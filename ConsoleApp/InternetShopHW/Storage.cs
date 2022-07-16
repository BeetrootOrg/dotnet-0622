namespace ConsoleApp.InternetShopHW;

class Storage
{
    public Product[] ListOfProducts { get; set; }
    public string LocationAddress { get; init; }

    public void RegisterNewProducts(Product[] newProducts)
    {
        Product[] tempArray = new Product[ListOfProducts.Length + newProducts.Length];
        ListOfProducts.CopyTo(tempArray, 0);
        newProducts.CopyTo(tempArray, ListOfProducts.Length);
        ListOfProducts = tempArray;
    }
}