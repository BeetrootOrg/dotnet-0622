namespace ConsoleApp.Library;

public class Library
{   
    public Athour[] Athours { get; set; }
    public string Name { get; set; }
    /// <summary>
    /// This is list books.
    /// </summary>
    /// <remarks>
    /// The first subarray stores the file index.
    /// The second subarray stores books.
    /// The name of which begins with the file index
    /// </remarks>
    public Book[,] Books { get; set; }
    public Reader[] Readers { get; set; }
    public string Address { get; set; }
    public PublishingHouse[] PublishingHouse { get; set; }
}
