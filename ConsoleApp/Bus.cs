namespace ConsoleApp.Autoservice;
using static System.Console;

enum Size
{
    Small,
    Medium,
    Large,
    ExtraLarge
}
class Bus : Vehicle
{
    public string TypeOfBus { get; set; }
    public Size Size { get; init; }

    public override void RepairDone()
    {
        TypeOfBreakdown();
        WriteLine("Impossible to fix");
    }
}