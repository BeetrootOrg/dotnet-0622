namespace ConsoleApp.BookLibrary;

class Author
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public Author(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

}
