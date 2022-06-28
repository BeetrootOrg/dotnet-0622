using ConsoleApp.BookLibrary;

var person1 = new Person
{
    FirstName = "Boris",
    LastName = "Johnson",
    Gender = Gender.Male,
    BirthDate = new DateTime(1964, 06, 19)
};

var author1 = new Author
{
    InfoAuthor = person1,
};

var book1 = new Book
{
    NameBook = "The Dream of Rome",
    BookAuthor = author1,
    PublicationDate = new DateTime(2006, 01, 28),
    LanguageBook = Language.English,
    Pages = 304

};

var book2 = new Book
{
    NameBook = "Have I Got Views For You",
    BookAuthor = author1,
    PublicationDate = new DateTime(2006, 06, 03),
    LanguageBook = Language.English,
    Pages = 448

};

var countBooks = new[]
{
    new BookCount
    {
        Book = book1,
        CountBooks = 4
    },

    new BookCount
    {
        Book = book2,
        CountBooks = 12
    }

};

var library = new Library
{
    LibraryBook = countBooks
};