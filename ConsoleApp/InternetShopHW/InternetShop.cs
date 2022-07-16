namespace ConsoleApp.InternetShopHW;

class InternetShop
{
    public string ShopDomian { get; set; }
    public Storage[] Storages { get; set; }
    public IBuyable[] CustomersDataBase { get; set; }
    public Worker[] Empolyees { get; set; }

    public void RegisterNewCustomer(IBuyable newCustomer)
    {
        int newArrayLength = CustomersDataBase.Length + 1;
        IBuyable[] tempArray = new IBuyable[newArrayLength];
        CustomersDataBase.CopyTo(tempArray, 0);
        tempArray[newArrayLength - 1] = newCustomer;
        CustomersDataBase = tempArray;
    }
}