namespace ConsoleApp.Autoservice;
using static System.Console;

class Transport
{
    public string RegistredNumber { get; set; }
    public int Power { get; set; }
    public DateTime Year { get; init; }
    public string VinNumber { get; init; }
    public Person Owner { get; set; }

    private void StartEngine()
    {
        Console.WriteLine("Engine Start... ");
    }

    private void StopEngine()
    {
        WriteLine("Engine Stop... ");
    }

    public void CheckBeforGo()
    {
        StartEngine();
    }
    public void CheckAfterStop()
    {
        StopEngine();
    }

    public virtual void Drive()
    {
        WriteLine("Im driving.... ");
    }
}