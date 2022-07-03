namespace ConsoleApp.LibraryClass;
public enum BookGenre
{
    Fantasy,
    SciFi,
    Education,
    Mystery,
    Thriller,
    Romance,
    Westerns,
    Dystopian,
    Contemporary
}
class Book
{
    public string Title { get; init; }
    public Author WrittenBy { get; init; }
    public BookGenre BookGenre { get; init; }
    public int YearOfBookPublication { get; init; }
} 