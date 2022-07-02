namespace ConsoleApp.LibraryHW;

class Book
{
    public string Name { get; init; }
    public Author BookAuthor { get; init; }
    public bool IsAvailable { get; set; }

    public Book(string name, Author bookAuthor, bool isAvailable)
    {
        Name = name;
        BookAuthor = bookAuthor;
        IsAvailable = isAvailable;
    }
}