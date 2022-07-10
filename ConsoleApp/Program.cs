namespace ConsoleApp.Autoservice;
using static System.Console;

class Program
{

    static void Main(string[] args)
    {
        var car1 = new Car
        {
            BodyType = "Sedan",
            Color = Color.Black,
            Power = 100,
            RegistredNumber = "ah12aa"

        };

        var bus1 = new Bus
        {
            Size = Size.Large,
            Color = Color.Yellow,
            TypeOfBus = "SchoolBus"
        };
        
    }
}
