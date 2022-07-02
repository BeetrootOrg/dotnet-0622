namespace ConsoleApp.LibraryHW;

class Worker
{
    public string Position { get; init; }
    public string FirstName { get; init; }
    public string LastName{ get; init; }
    public Worker(string position, string firstName, string lastName)
    {
        Position = position;
        FirstName = firstName;
        LastName = lastName;
    }
}