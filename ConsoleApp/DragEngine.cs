namespace Consoleapp;

public class DragEngine : Engine
{
    public int AmountOfPasses {get; set;}
    public override void DynoGraph()
    {
        Console.WriteLine("DynoGraph for an engine" + "Reliability graph");
    }
}