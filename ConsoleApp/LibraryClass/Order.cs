namespace ConsoleApp.LibraryClass;

class Order
{
    public Book OrderedBook { get; init; }
    public DateTime TakenOn { get; init; }
    public DateTime ReturnedOn { get; init; }
    public DateTime DueDate
    {
        get
        {
            return TakenOn.AddDays(14);
        }
    }
}