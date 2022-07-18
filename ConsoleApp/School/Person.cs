public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PatronymicName { get; set; }
    private DateTime Birthday { get; set; }
    public string Sex { get; set; }
    private string Adress { get; set; }
    public string NumberPhone { get; set; }
    public string Email { get; set; }

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