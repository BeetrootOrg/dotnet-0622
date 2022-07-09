namespace ConsoleApp.AutoService;

class Mechanic : Human
{
    private decimal _salary { get; set; }
    private DateTime _workingDays { get; set; }
    public override string Say() => base.Say() + "The car is repaired, please paid )";

    public Volkswagen Repair(Volkswagen carToRepair)
    {
        throw new NotImplementedException();
    }

}