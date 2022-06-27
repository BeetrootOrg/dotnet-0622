namespace ConsoleApp
{
    class Program
    {

        public static void Main(string[] args)

        {
            Book book = new Book();

            book.Title = "1984";
            book.Pagesize = 328;
            book.Publisher = "Jupanskogo";
            book.Color = ConsoleColor.Red;
            book.Publicationyear = 1949;
            book.Genre = "Dystopian";

            Author author = new Author();

            author.FirstName = "George";
            author.LastName = "Orwell";
            author.Age = 47;

            Customer customer = new Customer();

            customer.FirstName = "Jora";
            customer.LastName = "Kornev";
            customer.PhoneNumber = 664933;
            customer.Email = "Jorakornev@gmail.com";

            VistorLog log = new VistorLog();
            log.FirstName = "Jora";
            log.LastName = "Kornev";
            log.BookTaken = new DateTime(2014, 6, 14);
            log.ReturnedBook = new DateTime(2020, 8, 12);

            Employees rab = new Employees();

            rab.FirstName = "baba";
            rab.LastName = "lyuba";
            rab.BirthDate = new DateTime(1948, 1, 1);
            rab.worktime = 42;
        }
    }
}

