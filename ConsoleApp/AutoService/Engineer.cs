namespace AutoService;

class Engineer : Employee
{
    private double EngineerBonus {get;init;}
    public override double CalcultaPay()
    {
        return BaseSalary + EngineerBonus;
    }
}