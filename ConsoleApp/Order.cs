namespace ConsoleApp.LibraryClass;
class Order
{
    public Book BorowedBook { get; init; }
    public DateTime TakenOn { get; init; }
    public DateTime DueDate
    {
        get
        {
            return TakenOn.AddDays(30);
        }
    }
} 