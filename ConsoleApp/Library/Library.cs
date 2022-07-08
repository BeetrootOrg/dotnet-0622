namespace ConsoleApp.Library;

public class Library
{
    public String Name { get; set; }
    /// <summary>
    /// This is list books.
    /// </summary>
    /// <remarks>
    /// The first subarray stores the file index.
    /// The second subarray stores books.
    /// The name of which begins with the file index
    /// </remarks>
    public Book[,] books { get; set; }
    public Reader[] Readers { get; set; }
    public string Аddress { get; set; }
}
