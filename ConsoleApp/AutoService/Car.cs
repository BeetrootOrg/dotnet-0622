namespace ConsoleApp.AutoService;
using static System.Console;

public class Car
{
    public int MaxSpeed { get; set; }
    public string Year { get; set; }
    public int Cost { get; set; }
    public byte Wheels { get; set; } = 4;

    public virtual void GetCar()
    {
        WriteLine("I eat fuel");
    }
}