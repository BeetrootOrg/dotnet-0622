namespace ConsoleApp.LibraryClass;

class Library
{
    public string Address { get; init; }
    public Staff[] Workers { get; set; }
    public Book[] BookCollection { get; set; }
    public Visitor[] Visitors { get; set; }

}