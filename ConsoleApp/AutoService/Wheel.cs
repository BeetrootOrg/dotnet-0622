namespace AutoService;

class Wheel : Detail
{
    public double Width {get;init;}
    public double Diameter {get;init;}
    private double WheelPriceInstallation {get;set;}
    public override double CalculateInstallationPrice()
    {
        return BasePriceInstallation+WheelPriceInstallation;
    }
}