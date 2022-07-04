using System.IO;
using System.Text;

const string filePath = "baseContacts.csv";

void ShowRow((string, string, string) row)
{
    var (firstName, lastName, phone) = row;
    System.Console.WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
}
(string, string, string)[] ReadContacts(string file)
{
    var lines = File.ReadAllLines(file);
    var contacts = new (string, string, string)[lines.Length];
    for (int i = 0; i < lines.Length; i++)
    {
        var items = lines[i].Split(',');
        contacts[i] = (items[0], items[1], items[2]);
    }

    return contacts;
}

string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

void ShowAllContacts()
{
    var lines = ReadContacts(filePath);
    ShowRow(("First Name", "Last Name", "Phone"));
    foreach (var contact in lines)
    {
        ShowRow(contact);
    }

    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
void ExitProg()
{
    Environment.Exit(0);
};

void AddNewContacts()
{
    Console.Clear();
    System.Console.Write("Enter first name: ");
    var firstName = Console.ReadLine();
    System.Console.Write("Enter second name: ");
    var lastName = Console.ReadLine();
    System.Console.Write("Enter phone: ");
    var phone = Console.ReadLine();
    File.AppendAllLines(filePath, new[] { Serialize((firstName, lastName, phone)) });
}

void RemoveContact()
{
    Console.Clear();

    System.Console.WriteLine("Enter phone to remove:");
    var phoneToRemove = Console.ReadLine();

    var contacts = ReadContacts(filePath);
    var newContacts = new (string, string, string)[contacts.Length];
    Array.Copy(contacts, newContacts, contacts.Length);

    var index = 0;

    while (index < newContacts.Length)
    {
        if (newContacts[index].Item3 == phoneToRemove)
        {
            newContacts[index] = newContacts[^1];
            Array.Resize(ref newContacts, newContacts.Length - 1);
        }
        else
        {
            ++index;
        }
    }

    var csvBuilder = new StringBuilder();
    foreach (var contact in newContacts)
    {
        csvBuilder.AppendLine(Serialize(contact));
    }

    File.WriteAllText(filePath, csvBuilder.ToString());

    System.Console.WriteLine($"{contacts.Length - newContacts.Length} Contact(s) removed, press any key to continue");
    Console.ReadKey();
}

void SearchContact()
{
    System.Console.WriteLine("Enter Last\\second name or number: ");
    string searchContact = Console.ReadLine();
    var contacts = ReadContacts(filePath);
    var index = 0;

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[index].Item1 == searchContact
        || contacts[index].Item2 == searchContact
        || contacts[index].Item3 == searchContact)
        {
            ShowRow(contacts[i]);
        }
    }
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

}

void UpdateContact()
{
    var contacts = ReadContacts(filePath);
    ShowRow(("First Name", "Last Name", "Phone"));
    foreach (var contact in contacts)
    {
        ShowRow(contact);
    }
    System.Console.WriteLine("Enter the contact's number: ");
    string searchNumbContact = Console.ReadLine();
    System.Console.WriteLine("enter a new name:");
    string contactNewName = Console.ReadLine();
    System.Console.WriteLine("enter a new last name:");
    string contactNewLastName = Console.ReadLine();
    var index = 0;

    for (int i = 0; i < contacts.Length; i++)
    {
        if (contacts[index].Item3 == searchNumbContact)
        {
            contacts[index].Item1 = contactNewName;
            contacts[index].Item2 = contactNewLastName;
        }
        else { System.Console.WriteLine("no contacts found"); }
    }
    var csvBuilder = new StringBuilder();
    foreach (var contact in contacts)
    {
        csvBuilder.AppendLine(Serialize(contact));
    }
    File.WriteAllText(filePath, csvBuilder.ToString());
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

void MainlMenu()
{
    Console.Clear();
    System.Console.WriteLine("Phone Book");
    System.Console.WriteLine("Menu.");
    System.Console.WriteLine("1 - Show all contacts.");
    System.Console.WriteLine("2 - Add new contacts.");
    System.Console.WriteLine("3 - Update contacts.");
    System.Console.WriteLine("4 - Remove contacts.");
    System.Console.WriteLine("5 - Search contact.");
    System.Console.WriteLine("0 - Exit.");

    var keyPress = Console.ReadKey();

    switch (keyPress.Key)
    {
        case ConsoleKey.D0:
            ExitProg();
            break;

        case ConsoleKey.D1:
            ShowAllContacts();
            break;

        case ConsoleKey.D2:
            AddNewContacts();
            break;

        case ConsoleKey.D3:
            UpdateContact();
            break;

        case ConsoleKey.D4:
            RemoveContact();
            break;
        case ConsoleKey.D5:
            SearchContact();
            break;

        default:
            break;
    }
};

while (true)
{
    MainlMenu();
};