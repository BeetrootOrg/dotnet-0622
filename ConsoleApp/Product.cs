namespace ConsoleApp;

public class Product
{
    public string SKU {get; init;}
    public string Name {get; init;}
    public string FullName 
    {
        get
        {
            return FullNameInit( this.Name, this.ProductCategory);
        }
    }
    public int Price {get; init;} 
    public ProductCategory ProductCategory {get; init;}

    string FullNameInit(string name, ProductCategory productCategory)
    {
        string fullName = productCategory.ProductSuffix + " " + name;

        return fullName;
    }

    public Product ()
    {   


    }
    public void ShowProduct(Product product)
    {
        Console.WriteLine($"SKU: {product.SKU}, FullName: {product.FullName}, Price: {product.Price}");
    }

}