using ConsoleApp.InternetShopHW;
internal class Program
{
    private static void Main(string[] args)
    {
        XBoxSeriesX box1 = new XBoxSeriesX();
        XBoxSeriesX box2 = new XBoxSeriesX();
        XBoxSeriesX box3 = new XBoxSeriesX();
        XBoxSeriesX box4 = new XBoxSeriesX();
        XBoxSeriesX box5 = new XBoxSeriesX();
        XBoxSeriesX box6 = new XBoxSeriesX();
        XBoxSeriesX box7 = new XBoxSeriesX();

        XBoxSeriesX[] test = { box1, box2, box3, box4, box5, box6, box7 };
        Storage stor = new Storage();
        stor.ListOfProducts = test;
        System.Console.WriteLine(stor.ListOfProducts.Length);

        PlayStationFive ps1 = new PlayStationFive();
        PlayStationFive ps2 = new PlayStationFive();
        PlayStationFive ps3 = new PlayStationFive();
        PlayStationFive ps4 = new PlayStationFive();

        PlayStationFive[] plays = { ps1, ps2, ps3, ps4 };

        stor.RegisterNewProducts(plays);
        System.Console.WriteLine(stor.ListOfProducts.Length);

        Worker worker = new Worker();
        InternetShop shop = new InternetShop();
        shop.CustomersDataBase = new Worker[] { worker };
        Buyer buyer = new Buyer();
        shop.RegisterNewCustomer(buyer);
        System.Console.WriteLine(shop.CustomersDataBase.Length);
    }
}