
namespace ConsoleApp.AutoService;
class Motorbike : Vehicle

{
    public int Speed {get; init;}
    public Motorbike()
    {
        WheelNumber = 2;
    }

    public override void Accelerate()
    {
      RPM += 2000;
    }

}



