namespace ConsoleApp.AutoService;
using static System.Console;

public class Car
{
    public int MaxSpeed { get; init; }
    public string Year { get; init; }
    public int Cost { get; init; }
    public byte Wheels { get; init; } = 4;

    public virtual void GetCar()
    {
        WriteLine("I eat fuel");
    }
}