namespace ConsoleApp.AutoSrvice;


class Audi : Car
{
    public string ModelName { get; set; }
    public int EngineCapacity { get; set; }
    public GearType GearType { get; set; }
    public int NumberDoors { get; set; }

    public override void CarSound()
    {
        System.Console.WriteLine("Brrrrrr.....");
    }
}
