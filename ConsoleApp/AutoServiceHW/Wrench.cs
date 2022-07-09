namespace ConsoleApp.AutoServiceHW;

class Wrench : Tool
{
    public int Weight { get; init; }

    public override void UseTool()
    {
        base.UseTool();
        System.Console.WriteLine("And I help to unscrew doors!");
    }
}