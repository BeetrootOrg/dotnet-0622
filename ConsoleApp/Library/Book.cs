namespace ConsoleApp.Library;

public class Book
{
    public Athour Athour { get; set; }
    public string City { get; set; }
    public string Description { get; set; }
    public Format Format { get; set; }
    public string Genres { get; set; }
    /// <summary>
    /// ISBN - International Standard Book Numbers
    /// </summary>
    /// <value></value>
    public ISBN ISBookN { get; set; }
    public JournalEntryBook Journal { get; set; }
    public int PagesNumber { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
    public string Title { get; set; }
    public DateTime Year { get; set; }
}

public struct Format
{
    float Width;
    float Height;
    float PaperDensity;
}

public struct JournalEntryBook
{
    public DateTime ReturnDate { get; set; }
    public DateTime ReceiptDate { get; set; }
    public Reader Reader { get; set; }
}