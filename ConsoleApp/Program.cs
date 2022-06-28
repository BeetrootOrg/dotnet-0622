using System;
using System.IO;
using System.Text;

using static System.Console;

const string filename = "data.csv";

void Exit()
{
    Environment.Exit(0);
}

void ShowRow((string, string, string) row)
{
    var (firstName, lastName, phone) = row;
    WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
}

(string, string, string)[] ReadContactsTemp(string file)
{
    if (!File.Exists(file))
    {
        return Array.Empty<(string, string, string)>();
    }

    var lines = File.ReadAllLines(file);
    var contacts = new (string, string, string)[lines.Length];
    for (int i = 0; i < lines.Length; i++)
    {
        var items = lines[i].Split(',');
        if (items.Length != 3)
        {
            WriteLine($"ERROR WHILE READING {i + 1} LINE FROM {filename}.");
            continue;
        }

        contacts[i] = (items[0], items[1], items[2]);
    }

    return contacts;
}

(string, string, string)[] ReadContacts(string file)
{
    try
    {
        var lines = File.ReadAllLines(file);
        var contacts = new (string, string, string)[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            var items = lines[i].Split(',');

            try
            {
                contacts[i] = (items[0], items[1], items[2]);
            }
            catch (IndexOutOfRangeException ioore)
            {
                WriteLine($"ERROR WHILE READING {i + 1} LINE FROM {filename}. Message: {ioore.Message}");
            }
        }

        return contacts;
    }
    catch (FileNotFoundException)
    {
        return Array.Empty<(string, string, string)>();
    }
}
void ValidateNonSymbols(string name)
{
    for (int i = 0; i < name.Length; i++)
    {
        if (!char.IsLetter(name[i]) && !char.IsWhiteSpace(name[i]))
        {
            throw new IOException("Name must not contain symbols or digits");
        }
    }
}
void ShowAll()
{
    // 1. read content from file
    // 2. iterate in array of contacts
    // 3. show contact rows
    Clear();

    var contacts = ReadContactsTemp(filename);

    ShowRow(("First Name", "Last Name", "Phone"));
    foreach (var contact in contacts)
    {
        ShowRow(contact);
    }

    WriteLine("Press any key to continue...");
    ReadKey();
}

string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

void ValidateNonEmpty(string value, string message = null)
{
    if (string.IsNullOrWhiteSpace(value))
    {
        throw new ArgumentException(message, nameof(value));
    }
}
void ContainsDigits(string phone)
{
    if (!int.TryParse(phone, out int x))
    {
        throw new FormatException("Invalid phone number. Phone number must contain digits");
    }
}
void AddNewContact()
{
    try
    {
        Clear();

        WriteLine("Enter first name:");
        var firstName = Console.ReadLine();
        ValidateNonEmpty(firstName, "First name should be non-empty");
        ValidateNonSymbols(firstName);

        WriteLine("Enter last name:");
        var lastName = Console.ReadLine();
        ValidateNonEmpty(lastName, "Last name should be non-empty");
        ValidateNonSymbols(lastName);

        WriteLine("Enter phone:");
        var phone = Console.ReadLine();
        ValidateNonEmpty(phone, "Phone should be non-empty");
        ContainsDigits(phone);

        File.AppendAllLines(filename, new[] { Serialize((firstName, lastName, phone)) });

        WriteLine("Contact saved, press any key to continue");
        ReadKey();
    }
    catch (ArgumentException)
    {
        WriteLine("baran");
        throw;
    }
    catch (IOException inputError)
    {
        WriteLine(inputError.Message);
        ReadKey();
    }
    catch (FormatException error)
    {
        WriteLine(error.Message);
        ReadKey();
    }
    finally
    {
        WriteLine("finally done");
    }
}

void RemoveContact()
{
    Clear();

    WriteLine("Enter phone to remove:");
    var phoneToRemove = Console.ReadLine();

    var contacts = ReadContacts(filename);
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

    File.WriteAllText(filename, csvBuilder.ToString());

    WriteLine($"{contacts.Length - newContacts.Length} Contact(s) removed, press any key to continue");
    ReadKey();
}

void Search()
{
    try
    {
        Clear();

        WriteLine("What contact are you looking for?");
        var contactSearched = ReadLine();
        ValidateNonEmpty(contactSearched);
        var contacts = ReadContacts(filename);
        bool isFound = false;
        var index = 0;
        while (index < contacts.Length)
        {
            if (contacts[index].Item1 == contactSearched || contacts[index].Item2 == contactSearched)
            {
                isFound = true;
                ShowRow(contacts[index]);
            }
            index++;
        }
        if (!isFound)
        {
            Clear();
            WriteLine("Contact not found");
        }
        ReadKey();
    }
    catch (ArgumentException)
    {
        WriteLine("Invalid input");
        ReadKey();
    }
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
    WriteLine("\t5 - Search");
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
            Search();
            break;
        default:
            break;
    }
}
while (true)
{
    MainMenu();
}