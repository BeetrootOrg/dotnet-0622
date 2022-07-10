namespace ConsoleApp.InternetShop;

internal class Emploee : Client
{
    private int _emploeeId { get; init; }
    private decimal _emploeeSalary { get; set; }
    private DateTime _workingHours { get; set; }
}