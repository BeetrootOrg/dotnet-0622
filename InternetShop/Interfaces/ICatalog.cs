namespace InternetShop.Classes;

interface ICatalog
{
    void Add(Product product);

    void Take(Product product);

    void Reserve(Product product);
}