namespace ConsoleApp.AutoService;

class Vehicle
{
    public string Brand { get; init; }
    public string YearOfManufacturing { get; init; }
    public string Color { get; init; }
    public Wheel[] Wheels { get; init; }
    public Engine VehicleEngine { get; init; }
    public string LicensePlate { get; init; }

    public virtual void Drive()
    {
        System.Console.WriteLine("Wroom wroom");
    }
}

class Car : Vehicle
{
    public int DoorsQuantity { get; init; }
    public bool HasRoof { get; set; }

    public override void Drive()
    {
        System.Console.WriteLine("In car");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; init; }
}