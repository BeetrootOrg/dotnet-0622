namespace ConsoleApp.Library;

public class Reader : Person
{
    public int IDNumber { get; set; }
    public DateTime RegistrationDate { get; set; }
    public TimeSpan ValidityPeriod { get; set; }
    public int AccessLevel { get; set; }
    public JournalEntry[] Journal { get; set; }
}

public struct JournalEntry
{
    public DateTime ReturnDate { get; set; }
    public DateTime ReceiptDate { get; set; }
    public Book Book { get; set; }
}