namespace ConsoleApp.LibraryClass;

class Staff
{
    int _salary;
    public string FirstName { get; init; }
    public string SecondName { get; init; }
    public string Position { get; init; }

    public Staff(string firstName, string secondName, string position, int salary)
    {
        FirstName = firstName;
        SecondName = secondName;
        Position = position;
        _salary = salary;
    }
}