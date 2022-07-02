namespace ConsoleApp.LibraryHW;

class Section
{
    public int NumberOfBooks
    {
        get { return SectionBooks.Length; }
    }
    
    public string SectionName { get; init; }
    public Book[] SectionBooks { get; set; }

    public Section(string sectionName, Book[] sectionBooks)
    {
        SectionName = sectionName;
        SectionBooks = sectionBooks;
    }
    
}