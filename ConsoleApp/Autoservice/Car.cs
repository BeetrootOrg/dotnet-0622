namespace ConsoleApp.Autoservice;
using static System.Console;

class Car : Transport
{
    public string RoofType { get; init; }
    public string AcType { get; init; }

    public override void Drive()
    {
        CheckBeforGo();
        WriteLine("im driving car...  ");
        CheckAfterStop();
    }
}
