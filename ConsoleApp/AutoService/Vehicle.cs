namespace ConsoleApp.AutoService;

class Vehicle
{
    public string Production {get; init;}
    public int Year {get; init; }  
    public string Color {get; init;}
    public int RPM {get; protected set;}
    public int WheelNumber {get; init; }

    public void Ignite()
    {
        RPM = 1000;
    }

    virtual public void Accelerate()
    {
        RPM += 1000;
    }
}
