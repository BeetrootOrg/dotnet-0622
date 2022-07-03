namespace ConsoleApp.LibraryClass;

class LibStaff
{
    int wages;
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string JobTitle { get; init; }
    public LibStaff(string firstName, string lastName, string position, int salary)
    {
        FirstName = firstName;
        LastName = lastName;
        JobTitle = position;
        wages = salary;
    }
} 