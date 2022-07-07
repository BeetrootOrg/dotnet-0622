using ConsoleApp.BookLibrary;
namespace ConsoleApp;
partial class Program
{
    static void Main ()
    {
        Library dailybooks = new Library ("DailyBooks", "18 Levinski Street","dailybook@gmail.com", "120099");
        Library perfectbook = new Library ("PerfectBook", "10 Williams Street", "bookforyou@gmail.com", "13800");
        Library [] libraries = {dailybooks, perfectbook};

        Author rowling = new Author ("Joanne", "Rowling");
        Author hosseini = new Author ("Khaled", "Hosseini");
        Author [] authors = {rowling, hosseini};

        Book harrypotter = new Book ("Harry Potter and the Philosopher's Stone", rowling, Genre.Fantasy, Language.English);
        Book splendidsuns = new Book ("A Thousand Splendid Suns", hosseini, Genre.Fiction, Language.English);
        Book [] books = {harrypotter, splendidsuns};

    }
}