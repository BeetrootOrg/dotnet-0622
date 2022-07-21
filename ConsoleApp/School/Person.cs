namespace ConsoleApp.School;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    internal string PatronymicName { get; set; }
    private DateTime Birthday { get; set; }
    internal string Sex { get; set; }
    internal string Adress { get; set; }
    internal string NumberPhone { get; set; }
    internal string Email { get; set; }

    public string GetStandartName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public int Age()
    {
        return DateTime.Now.Year - Birthday.Year;
    }

    public int Age(Person person)
    {
        return DateTime.Now.Year - person.Birthday.Year;
    }

    public string City()
    {
        return Adress.Split(',')[2];
    }
}