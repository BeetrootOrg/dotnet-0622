namespace ConsoleApp.Library;

class Library
{
    public string Name { get; init; }
    public string Address { get; init; }
    public string PhoneNumber { get; init; }
    public string Email { get; init; }
    public Book[] Books { get; set; }
    public Visitor[] Visitors { get; set; }

    public void AddBook(Book book)
    {
        Book[] buffer = new Book[Books.Length+1];
        Books.CopyTo(buffer, 0);
        buffer[buffer.Length] = book;
        Books = buffer;
    }

    public void  RegisterNewVisitor(Visitor visitor)
    {
        Visitor[] buffer = new Visitor[Books.Length+1];
        Visitors.CopyTo(buffer, 0);
        buffer[buffer.Length] = visitor;
        Visitors = buffer;
    }


}