namespace ConsoleApp.LibraryClass;
public enum Genre
{
    Thriller,
    Horror,
    Romance,
    Comedy,
    Fantasy,
    Classics,
    Biography
}
class Book
{
    public string Title { get; init; }
    public Author WrittenBy { get; init; }
    public Genre BookGenre { get; init; }
    public int PublicationYear { get; init; }
}