namespace ConsoleApp.AutoService;
class Car : Vehicle
{
    public int Mileage { get; init; }

    public string Assembly { get; init; }
    public Car()
    {
        WheelNumber = 4;
    }
    public override void Accelerate()
    {
        RPM += 4000;
    }

}
