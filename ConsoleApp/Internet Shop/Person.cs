namespace ConsoleApp.InternetShop;

abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; init; }

    public abstract void GetInfo();

}