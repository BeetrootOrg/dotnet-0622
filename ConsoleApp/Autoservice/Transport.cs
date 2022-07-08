namespace ConsoleApp.Autoservice;
using static System.Console;

class Transport
{
    public string RegistredNumber { get; set; }
    public int Power { get; set; }
    public DateTime Year { get; init; }
    public string VinNumber { get; init; }
    public Person Owner { get; set; }



    public void StartEngine()
    {
        Console.WriteLine("Engine Start... ");
    }

    public void StartStop()
    {
       WriteLine("Engine Stop... ");
    }

}