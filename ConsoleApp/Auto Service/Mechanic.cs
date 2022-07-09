namespace ConsoleApp.AutoService;

class Mechanic : Employee
{
    int _experience;
    public string Specialty { get; init; }

    public Mechanic(string firstName, string lastName, string position, int salary, string speciality, int experience)
        : base(firstName, lastName, position, salary)
    {
        Specialty = speciality;
        _experience = experience;
    }
    public void Analyze()
    {
        throw new NotImplementedException();
    }
    public void Fix()
    {
        throw new NotImplementedException();
    }
    public override void Work()
    {
        base.Work();
    }
}