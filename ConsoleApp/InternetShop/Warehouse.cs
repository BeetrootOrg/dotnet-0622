namespace ConsoleApp.InternetShop;

class Warehouse
{
    private int _warehouseId { get; set; }
    public int WarehouseCapacity { get; private set; }
    public IWarehouse Product { get; set; }
}

interface IWarehouse : IProduct, IProductSupply
{
    public Product CreateProduct();
    public void ProductSupply(Product product);
    public void WarehouseCheck();

}