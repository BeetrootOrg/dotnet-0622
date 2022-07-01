namespace ConsoleApp;
class Teacher : Person
{
    public Subject Subject {get; init;}

    public Teacher ()
    {
        Console.WriteLine ("Teacher Construcotr");
    }

    public string GetPerson() => $"First Name = {FirstName};Last Name = {LastName};Date of Birth = {DateBirth}; Subject = {Subject}";
}
