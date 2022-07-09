namespace ConsoleApp.AutoServiceHW;

class Vehicle
{
    public Engine CarEngine { get; set; }
    public Wheel[] Wheels { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Milage { get; set; }

    public Vehicle(Engine engine, Wheel[] wheels, string brand, string model, double milage)
    {
        CarEngine = engine;
        Wheels = wheels;
        Brand = brand;
        Model = model;
        Milage = milage;
    }

    public virtual void Accelerate()
    {
        System.Console.WriteLine("Forward!");
    }

    public virtual void Brake()
    {
        System.Console.WriteLine("Breaking!");
    }
}