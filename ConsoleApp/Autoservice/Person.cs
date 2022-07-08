namespace ConsoleApp.Autoservice;
using static System.Console;

class Person
{
    public string FirstName { get; init; }
    public string LastName { get; set; }
    private DateTime _birthday { get; init; }
    private string _email { get; set; }


    public virtual void Drive()
    {
        WriteLine("Im driving.... ");
    }


}
