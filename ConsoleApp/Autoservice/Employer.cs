namespace ConsoleApp.Autoservice;
using static System.Console;

class Employer : Person
{
    public DateTime StartDate { get; init; }
    private decimal _salary { get; set; }

    public override void CheckRules()
    {
        WriteLine("override for Employer");
    }
}