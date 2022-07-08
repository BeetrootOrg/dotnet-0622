namespace ConsoleApp.Library;

public class Book
{
    public string City { get; set; }
    public Athour Athour { get; set; }
    public string Title { get; set; }
    public DateTime Year { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
    public int PagesNumber { get; set; }
    public string Genres { get; set; }

    /// <summary>
    /// ISPN - International Standard Publication Numbers
    /// </summary>
    /// <value></value>
    public ISBN ISBookN { get; set; }
    public string Description { get; set; }

    public Format Format { get; set; }
}
    public struct Format
    {
        float Width;
        float Height;
        float PaperDensity;
    }