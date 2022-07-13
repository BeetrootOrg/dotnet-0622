namespace ConsoleApp.InternetShop;
partial class Program
{
    static void Main()
    {
        var wardrobe1 = new Wardrobe ( 150, 1, 50 );
        var table1 = new Table (100, 1, 90);  

        wardrobe1.AddQuantity();
        table1.AddQuantity();
    
    }

}