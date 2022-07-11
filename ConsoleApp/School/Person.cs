namespace ConsoleApp.School;

class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    private string email { get; set; }

    public Person()
    {
        
        Console.WriteLine ("Purson Constructor");
    }

    public string GetPerson() => $"First Name = {FirstName};Last Name = {LastName}; email = {email}";
}