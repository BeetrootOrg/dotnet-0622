namespace ConsoleApp.SchoolHW;

class Employee
{
    private int _salary;
    public string FullName { get; init; }
    public string Position { get; set; }
    
    public Employee(int salary, string fullName, string position)
    {
        _salary = salary;
        FullName = fullName;
        Position = position;
    }

    public void Promote(string newPosition)
    {
        Position = newPosition;
    }
    public void RaiseSalary(int raise)
    {
        _salary +=raise;
    }
}