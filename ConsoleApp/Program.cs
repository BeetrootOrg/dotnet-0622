using System;
using System.IO;
using System.Text;

using static System.Console;

const string filename = "data.csv";

void Exit()
{
    Environment.Exit(0);
}

void ShowRow((string, string, string, string) row)
{
    var (No, firstName, lastName, phone) = row;
    WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", No, firstName, lastName, phone);
}

(string, string, string, string)[] ReadContacts(string file)
{
    var lines = File.ReadAllLines(file);
    var contacts = new (string, string, string, string)[lines.Length];
    for (int i = 0; i < lines.Length; i++)
    {
        var items = lines[i].Split(',');
        contacts[i] = ((i + 1).ToString(), items[0], items[1], items[2]);
    }

    return contacts;
}

void ShowAll()
{
    // 1. read content from file
    // 2. iterate in array of contacts
    // 3. show contact rows
    // 4. search
    Clear();

    var contacts = ReadContacts(filename);

    ShowRow(("No", "First Name", "Last Name", "Phone"));
    foreach (var contact in contacts)
    {
        ShowRow(contact);
    }

    WriteLine("Press any key to continue...");
    ReadKey();
}

string Serialize((string No, string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

void SearchContact()
{
    Clear();

    WriteLine("Enter name or phone:");
    var query = "";
    query = Console.ReadLine();

    var contacts = ReadContacts(filename);

    WriteLine($"The result of searching for {query} is:");
    ShowRow(("No", "First Name", "Last Name", "Phone"));

    bool isResult = false;
    foreach (var contact in contacts)
    {
        if (query != null)
        {
            if (contact.Item1.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                contact.Item2.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                contact.Item3.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                ShowRow(contact);
                isResult = true;
            }
        }
    }

    if (!isResult) WriteLine ("No such contacts");
    WriteLine("Press any key to continue");
    ReadKey();
}

void UpdateContact()
{
    Clear();

    ShowAll();

    WriteLine("Enter row to update:");
    var console = Console.ReadLine();

    int rowToUpdate;
    if (!int.TryParse(console, out rowToUpdate))
        { 
            Console.WriteLine("is not an integer number, run again and put right value");
        }   

    var contacts = ReadContacts(filename);
    var newContacts = new (string, string, string, string)[contacts.Length];
    Array.Copy(contacts, newContacts, contacts.Length);
    
    WriteLine("Enter first name:");
    var firstName = Console.ReadLine();

    WriteLine("Enter last name:");
    var lastName = Console.ReadLine();

    WriteLine("Enter phone:");
    var phone = Console.ReadLine();
        
    newContacts[rowToUpdate - 1] = ((rowToUpdate).ToString(), firstName, lastName, phone);

    var csvBuilder = new StringBuilder();

    foreach (var contact in newContacts)
    {
        csvBuilder.AppendLine(Serialize(contact));
    }

    File.WriteAllText(filename, csvBuilder.ToString());

    WriteLine($"{rowToUpdate} contact was updated, press any key to continue");
    ReadKey();
}

void AddNewContact()
{
    Clear();

    WriteLine("Enter first name:");
    var firstName = Console.ReadLine();

    WriteLine("Enter last name:");
    var lastName = Console.ReadLine();

    WriteLine("Enter phone:");
    var phone = Console.ReadLine();

    File.AppendAllLines(filename, new[] { Serialize(("", firstName, lastName, phone)) });

    WriteLine("Contact saved, press any key to continue");
    ReadKey();
}

void RemoveContact()
{
    Clear();

    WriteLine("Enter phone to remove:");
    var phoneToRemove = Console.ReadLine();

    var contacts = ReadContacts(filename);
    var newContacts = new (string, string, string, string)[contacts.Length];
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

    File.WriteAllText(filename, csvBuilder.ToString());

    WriteLine($"{contacts.Length - newContacts.Length} Contact(s) removed, press any key to continue");
    ReadKey();
}

void MainMenu()
{
    Clear();

    WriteLine("Welcome to phone book!");
    WriteLine();
    WriteLine("Menu:");
    WriteLine("\t1 - Show all contacts");
    WriteLine("\t2 - Add new contact");
    WriteLine("\t3 - Update contact");
    WriteLine("\t4 - Remove contact");
    WriteLine("\t5 - Search for contact");
    WriteLine("\t6 - Update contact");
    WriteLine("\t0 - Exit");

    var key = ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.D0:
            Exit();
            break;
        case ConsoleKey.D1:
            ShowAll();
            break;
        case ConsoleKey.D2:
            AddNewContact();
            break;
        case ConsoleKey.D4:
            RemoveContact();
            break;
        case ConsoleKey.D5:
            SearchContact();
            break;
        case ConsoleKey.D6:
            UpdateContact();
            break;
        default:
            break;
    }
}

while (true)
{
    MainMenu();
}