namespace ConsoleApp.PhoneBook;

using static System.Console;

class PhoneBook
{
    public PhoneBookRecord[] Contacts { get; init; }

    public void ShowAll()
    {
        WriteLine("{0,-20}{1,-20}{2,-20}", "First Name", "Last Name", "Phone");
        foreach (var contact in Contacts)
        {
            WriteLine($"{contact.Person.FirstName,-20}{contact.Person.LastName,-20}{contact.PhoneNumber,-20}");
        }
    }
}