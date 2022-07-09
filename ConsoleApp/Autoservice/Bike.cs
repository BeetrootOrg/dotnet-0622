namespace ConsoleApp.Autoservice;
using static System.Console;

class Bike : Transport
{
    public bool CrossBike { get; init; }

    private void WearHelmet()
    {
        WriteLine("I put on a helmet... ");
    }

    public override void Drive()
    {
        CheckBeforGo();
        WearHelmet();
        WriteLine("im driving cool bike... uhuuuhhhuu... ");
        CheckAfterStop();
    }
}