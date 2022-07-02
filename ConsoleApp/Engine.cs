namespace Consoleapp;

public enum EngineType
{
    inline,
    v,
    boxer
}
public class Engine
{
    public EngineType EngineType { get; set; }
    public int Cylinders { get; set; }
    public int HorsePower { get; set; }
    public int Torque { get; set; }

    public virtual void DynoGraph()
    {
        Console.WriteLine("DynoGraph for an engine");
    }
}