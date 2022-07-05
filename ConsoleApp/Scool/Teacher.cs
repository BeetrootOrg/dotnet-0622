namespace ConsoleApp.Scool;

class Teacher : Person
{
    public DateTime DateOfStart { get; init; }
    public string Category { get; set; }
    private decimal _salary { get; set; }
}
