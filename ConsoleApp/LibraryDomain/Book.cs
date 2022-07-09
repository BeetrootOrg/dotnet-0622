using ConsoleApp.LibraryDomain;

class Book
{
    public string BookName { get; set; } = "";
    public string Author { get; set; } = "";
    public string Genre { get; set; } = "";
    public int AmountOfPages { get; set; }

    public Book(){}
    public Book(string bookName, string author, string genre, int amountOfPages)
    {
        BookName = bookName;
        Author = author;
        Genre = genre;
        AmountOfPages = amountOfPages;
    }
}