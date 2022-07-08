using ConsoleApp.AutoService;

public class Program
{
    static void Main(string[] args)
    {
        Truck car1 = new Truck
        {
            MaxSpeed = 120,
            Year = "2020",
            Cost = 15000,
            Wheels = 8,
            CarModel = "VW",
            CarColor = Color.Black,
            CarEngine = Engine.Disel
        };
        car1.GetCar();
    }
}