namespace ConsoleApp.LibraryHW;

class Author
{
    public string FirstName { get; init; }
    public string LastName{ get; init; }
    public DateOnly DateOfBirth{ get; init; }

    public Author(string firstName, string lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}