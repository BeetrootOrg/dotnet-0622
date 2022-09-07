namespace InternetShop.Classes;

interface IOrder
{
    void AddProduct(Product product);

    void RemoveProduct(Product product);

    void ClearProducts();
}