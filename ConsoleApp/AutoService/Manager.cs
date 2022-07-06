namespace AutoService;

class Manager : Employee
{
    private double ManagerBonus {get;init;}
    public override double CalcultaPay()
    {
        return BaseSalary + ManagerBonus;
    }
}