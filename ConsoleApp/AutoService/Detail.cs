namespace AutoService;

class Detail 
{
    public string Name {get;init;}
    public string Manufacturer {get;init;}
    public double Weight {get; init;}
    public double Price {get;set;}
    protected double BasePriceInstallation {get;set;}
    public virtual double CalculateInstallationPrice()
    {
        return BasePriceInstallation;
    }

}