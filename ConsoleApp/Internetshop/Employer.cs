namespace ConsoleApp.Internetshop;
class Employer : Person
{
    public DateTime StartDate { get; init; }
    private decimal _salary { get; set; }
    public bool IsClientTo { get; set; }
    public Client ClientEmployer { get; set; }
}