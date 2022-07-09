namespace ConsoleApp.AutoService;

class Employee : Person
{
    int _salary;
    public string Position { get; set; }

    public Employee(string firstName, string lastName, string position, int salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        _salary = salary;
    }

    public virtual void Work()
    {
        System.Console.WriteLine("The work is in process");
    }
}
