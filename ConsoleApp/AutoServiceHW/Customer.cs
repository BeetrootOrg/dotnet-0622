namespace ConsoleApp.AutoServiceHW;

class Customer : Human
{
    public Vehicle CarToRepair { get; init; }
    public int Budget { get; set; }

    public override void PerformAction(Tool tool)
    {
        System.Console.WriteLine("Doing typical customer stuff!");
        base.PerformAction(tool);
    }
}