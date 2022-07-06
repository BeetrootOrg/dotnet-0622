namespace AutoService;

class Engine : Detail
{
    public string Type {get;init;}
    public double Power {get;init;}
    private double EnginelPriceInstallation {get;set;}
    public override double CalculateInstallationPrice()
    {
        return BasePriceInstallation+EnginelPriceInstallation;
    }
}