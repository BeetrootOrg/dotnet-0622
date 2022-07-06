namespace AutoService;

class Employee
{
    public string Name {get;init;}
    protected double BaseSalary {get;init;}
    public virtual double CalcultaPay()
    {
        return BaseSalary;
    }
}