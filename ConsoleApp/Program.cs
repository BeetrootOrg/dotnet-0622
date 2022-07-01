using ConsoleApp.LibraryClass;
namespace ConsoleApp;
partial class Program
{
    static void Main(string[] args)
    {
        Staff worker1 = new Staff("John", "Doe", "Senior Librarian", 15000);
        Author tHarris = new Author
        {
            FirstName = "Thomas",
            SecondName = "Harris",
            CountryOfOrigin = "USA"
        };

        Author jRowling = new Author
        {
            FirstName = "Joanne",
            SecondName = "Rowling",
            CountryOfOrigin = "Great Britain"
        };

        Console.WriteLine(tHarris.FullName);

        Book silenceOfTheLambs = new Book
        {
            Title = "Silence of the Lambs",
            WrittenBy = tHarris,
            BookGenre = Genre.Thriller,
            PublicationYear = 1988,
        };
        Book harryPotter2 = new Book
        {
            Title = "Harry Potter and the Chamber of Secrets",
            WrittenBy = jRowling,
            BookGenre = Genre.Fantasy,
            PublicationYear = 1998,
        };
        Order firstOrder = new Order
        {
            OrderedBook = silenceOfTheLambs,
            TakenOn = DateTime.Today
        };
        Order secondOrder = new Order
        {
            OrderedBook = harryPotter2,
            TakenOn = DateTime.Today.AddDays(-2)
        };
        Visitor nTelelym = new Visitor
        {
            FirstName = "Veronika",
            SecondName = "Telelym",
            OrderedBooks = new[] { firstOrder, secondOrder }
        };
        Library centralLibrary = new Library
        {
            Address = "Pastera 13, Odesa",
            BookCollection = new[] {silenceOfTheLambs, harryPotter2},
            Workers = new[] {worker1},
            Visitors = new[] {nTelelym}
        };
    }
}
