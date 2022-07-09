namespace ConsoleApp.AutoServiceHW;

class BankingCard : Tool
{
    public string CardNumber { get; init; }

    public override void UseTool()
    {
        base.UseTool();
        System.Console.WriteLine("I am paying for repair!");
    }
}