using ConsoleApp.Library;

var author = new Author
{
    FirstNameAuthor = "Mark",
    LastNameAuthor = "Twain"
};

var book = new Book
{
    NameBook = "The Adventures of Tom Sawyer",
    Authors = author,
    LanguageBook = Language.English,
    Pages = 107,
    DatePublic = "1876"
};

var memberCards = new MemberCards
{
    IdMember = 1833,
    FirstNameMember = "Alex",
    LastNameMember = "Grabovsky",
    PhoneNumberMember = "+380951234567",
    EmailMember = "something@gmail.com"
};