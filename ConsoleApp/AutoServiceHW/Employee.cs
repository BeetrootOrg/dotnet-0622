namespace ConsoleApp.AutoServiceHW;

class Employee : Human
{
    int _salary;
    public string Position { get; set; }

    public override void PerformAction(Tool tool)
    {
        System.Console.WriteLine("Same day as every other!");
        base.PerformAction(tool);
    }
}