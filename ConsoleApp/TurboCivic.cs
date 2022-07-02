namespace Consoleapp;

public class TurboCivic : Car
{
    public int RustPersentage { get; set; }
    public bool IsKanjo { get; set; }

    public override void CarSound()
    {
        Console.WriteLine("RATATATATA!!!");
    }
}