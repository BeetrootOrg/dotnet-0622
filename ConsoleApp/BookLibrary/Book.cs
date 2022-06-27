namespace ConsoleApp.BookLibrary;

class Book
{
    public string NameBook { get; init; }
    public Author BookAuthor { get; init; }
    public DateTime PublicationDate { get; init; }
    public Language LanguageBook { get; init; }
    public int Pages { get; init; }
    
}