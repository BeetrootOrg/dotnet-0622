namespace ConsoleApp.LibraryClass;
class Author
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
} 