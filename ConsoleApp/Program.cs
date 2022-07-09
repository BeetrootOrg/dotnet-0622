using ConsoleApp.LibraryDomain;

Person person = new Person("qwerty","kik",21);

var person1 = new Person
{
    FirstName = "sivart",
    LastName = "ttocs",
    Age = 32,
};

Visitor visitor = new Visitor("cv","vc",22);

Staff staff1 = new Staff("manager","jhon","abet", 23);

var a = new Book
{
    BookName = "!learn c# in one day",
    Author = "Ben",
    AmountOfPages = 12,
    Genre = "fairytale"
};
Book b = new Book
{
    BookName = "!learn c# in one day update version",
    Author = "Ben",
    AmountOfPages = 13,
    Genre = "science fiction"
};

var books = new []
{
    new Book
    {
        BookName = "asdf",
        Author = "George",
        AmountOfPages = 236,
        Genre = "fiction"
    },
    new Book
    {
        BookName = "fdsa",
        Author = "Paul",
        AmountOfPages = 112,
        Genre = "poem"
    }
};

Library smallOne = new Library
{
    Books = books
};

System.Console.WriteLine(person1.ToString());
System.Console.WriteLine(visitor.ToString());