namespace ConsoleApp;
class Person
{
    public string FirstName {get; init;}
    public string LastName {get; init;}
    public DateTime DateBirth {get; init;}
       
    public Person()
    {
        
        Console.WriteLine ("Purson Constructor");
    }

    public string GetPerson() => $"First Name = {FirstName};Last Name = {LastName};Date of Birth = {DateBirth}";

}