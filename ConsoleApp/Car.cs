namespace ConsoleApp.Autoservice;
using static System.Console;

class Car : Vehicle
{
    public string BodyType { get; init; }

    public override void RepairDone()
    {
        TypeOfBreakdown();
        WriteLine("All good");
    }
}
