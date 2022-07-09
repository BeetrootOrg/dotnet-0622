namespace ConsoleApp.AutoServiceHW;

class Honda : Vehicle
{
    public string LevelOfCoolness { get => "10/10"; }

    public Honda(Engine engine, Wheel[] wheels, string brand, string model, double milage)
        : base(engine, wheels, brand, model, milage) { }


    public override void Accelerate()
    {
        base.Accelerate();
        System.Console.WriteLine("With 10/10 coolness now");
    }
    public override void Brake()
    {
        base.Brake();
        System.Console.WriteLine("With 10/10 coolness now");
    }

}