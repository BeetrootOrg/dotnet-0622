namespace ConsoleApp.LibraryClass;
class Author
{
    public string FirstName { get; init; }
    public string SecondName { get; init; }
    public string FullName
    {
        get
        {
            return FirstName + " " + SecondName;
        }
    }
    public string CountryOfOrigin { get; init; }
}