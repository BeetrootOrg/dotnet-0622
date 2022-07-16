using static System.Console;

namespace ConsoleApp.InternetShop;

class Employee : Person
{
    int _salary;
    public string Position { get; set; }
    public int EmployeeDiscount { get; set; }

    public override void ShowInfo()
    {
        WriteLine(@$"Full Name: {FirstName}, {LastName}
        Salary: {_salary}
        Position: {Position}
        Discount: {EmployeeDiscount}");
    }
}