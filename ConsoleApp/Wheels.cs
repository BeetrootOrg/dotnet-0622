namespace Consoleapp;

public enum Material
{
    Alloy,
    Steel,
    Magnezium
}
public class Wheels
{
    public int Radius { get; set; }
    public int Weight { get; set; }
    public int Price { get; set; }
    public string Name { get; set; }
    public Material Material { get; set; }
}