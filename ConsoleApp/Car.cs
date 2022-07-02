namespace Consoleapp;
public enum Type
{
    Sedan,
    Hatchback,
    SUV,
    Coupe
}
public class Car
{
    public Type Type { get; set; }
    public int Weight { get; set; }
    public int PassangerSeats { get; set; }
    public string FuelType { get; set; }
    public int Price { get; set; }

    public virtual void CarSound()
    {
        Console.WriteLine("Brrrrrrr");
    }
}

