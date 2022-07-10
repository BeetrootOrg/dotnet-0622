namespace ConsoleApp.Autoservice;
using static System.Console;

enum Color
{
    Black,
    White,
    Yellow,
    Red,
    Grey,
    Blue
}
class Vehicle
{
    public string RegistredNumber { get; set; }
    public int Power { get; set; }
    public DateTime Year { get; init; }
    public Color Color { get; init; }

    public void TypeOfBreakdown()
    {
        throw new NotImplementedException();
    }

    private void RepairTime()
    {
        throw new NotImplementedException();
    }

    public virtual void RepairDone()
    {
        WriteLine("All problems fixed");
    }

}