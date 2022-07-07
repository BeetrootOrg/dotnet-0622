namespace ConsoleApp.BookLibrary;

class Book
{
    public string BookTitle { get; init; }
    public Author BookAuthor { get; init; }
    public Genre BookGenre { get; init; }
    public Language BookLanguage { get; init; }

    public Book(string bookTitle, Author bookAuthor, Genre bookGenre, Language bookLanguage)
    {
        BookTitle = bookTitle;
        BookAuthor = bookAuthor;
        BookGenre = bookGenre;
        BookLanguage = bookLanguage;
    }

}