namespace ConsoleApp.AutoService;
using static System.Console;

public class Truck : Car
{
    public Color CarColor { get; init; }
    public Engine CarEngine { get; init; }
    public string CarModel { get; init; }

    public override void GetCar()
    {
        switch (CarEngine)
        {
            case Engine.Disel:
                WriteLine($"I eat {Engine.Disel}!");
                break;
            case Engine.Gasoline:
                WriteLine($"I eat {Engine.Gasoline}!");
                break;
        }
    }
}
