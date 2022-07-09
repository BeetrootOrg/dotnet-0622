namespace ConsoleApp.InternetShopHW;

abstract class Person
{
    public string FullName { get; init; }
    public string CityOfLiving { get; set; }
    
    public abstract void GetWishOfLife();
}