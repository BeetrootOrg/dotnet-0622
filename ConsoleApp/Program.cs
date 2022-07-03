using ConsoleApp.LibraryClass;
namespace ConsoleApp;
partial class Program
{
    static void Main(string[] args)
    {
        Author jA = new Author
        {
            FirstName = "Joseph",
            LastName = "Albahari"
        };
        System.Console.WriteLine(jA.FullName);

        Book cSharpTenInANutshell = new Book
        {
            Title = "C# 10 in a Nutshell",
            WrittenBy = jA,
            BookGenre = BookGenre.Education,
            YearOfBookPublication = 2022,
        };
        Order order1 = new Order
        {
            BorowedBook = cSharpTenInANutshell,
            TakenOn = DateTime.Now
        };

        Book cSharpTenPocketReference = new Book
        {
            Title = "C# 10 Pocket Reference",
            WrittenBy = jA,
            BookGenre = BookGenre.Education,
            YearOfBookPublication = 2022,
        };

        Order order2 = new Order
        {
            BorowedBook = cSharpTenPocketReference,
            TakenOn = DateTime.Now
        };

        LibVisitor markJPrice = new LibVisitor
        {
            FirstName = "Mark",
            LastName = "J.Price",
            TakenBooks = new [] {order1, order2}
        };
        LibStaff employee1 = new LibStaff("Alex", "Newell", "Manager of Library", 30000);
    }
}