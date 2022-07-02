using System;
using System.IO;
using System.Text;

using static System.Console;

class ContactNotFoundException : Exception
{
    public ContactNotFoundException() { }

    public ContactNotFoundException(string message)
        : base(message) { }

}
internal class Program
{
    const string filename = "data.csv";

    static void Exit()
    {
        Environment.Exit(0);
    }

    static void ShowRow((string, string, string) row)
    {
        var (firstName, lastName, phone) = row;
        WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
    }

    static (string, string, string)[] ReadContactsTemp(string file)
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

    static (string, string, string)[] ReadContacts(string file)
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

    static void ShowAll()
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

        MakeDelay();
    }

    static string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

    static void ValidateNonEmpty(string value, string message = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(message, nameof(value));
        }
    }

    static void AddNewContact()
    {
        try
        {
            Clear();

            WriteLine("Enter first name:");
            var firstName = ReadLine().Trim();
            ValidateNonEmpty(firstName, "First name should be non-empty");

            WriteLine("Enter last name:");
            var lastName = ReadLine().Trim();
            ValidateNonEmpty(lastName, "Last name should be non-empty");

            WriteLine("Enter phone:");
            var phone = ReadLine().Trim();
            ValidateNonEmpty(lastName, "Phone should be non-empty");

            File.AppendAllLines(filename, new[] { Serialize((firstName, lastName, phone)) });

            WriteLine("Contact saved, press any key to continue");
            ReadKey();
        }
        catch (ArgumentException)
        {
            WriteLine("baran");
            throw;
        }
        finally
        {
            WriteLine("finally done");
        }
    }

    static void RemoveContact()
    {
        Clear();

        WriteLine("Enter phone to remove:");
        var phoneToRemove = ReadLine();

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

        RewriteContacts(newContacts);

        WriteLine($"{contacts.Length - newContacts.Length} Contact(s) removed, press any key to continue");
        ReadKey();
    }
    static void SearchContact()
    {
        try
        {
            Clear();
            var contacts = ReadContacts(filename);
            WriteLine("Enter Contact First or Last Name:");
            string searchKey = ReadLine();

            int counter = 0;
            foreach (var (firstName, lastName, phoneNumber) in contacts)
            {
                if (firstName.ToLower() == searchKey.ToLower() || lastName.ToLower() == searchKey.ToLower())
                {
                    ShowRow((firstName, lastName, phoneNumber));
                    ++counter;
                }
            }
            if (counter == 0)
            {
                throw new ContactNotFoundException("No Contacts Found!");
            }
            WriteLine($"{counter} {(counter == 1 ? "contact was" : "contacts were")} found");
        }
        catch (ContactNotFoundException cnfe)
        {
            WriteLine(cnfe.Message);
        }
        MakeDelay();

    }
    static void UpdateContact()
    {
        try
        {
            Clear();
            var contacts = ReadContacts(filename);
            WriteLine("Provide Information About The Contact You Would Like To Update");
            WriteLine("First Name:");
            string firstName = ReadLine();
            ValidateNonEmpty(firstName, "Invalid Data Entered!");
            WriteLine("Last Name:");
            string lastName = ReadLine();
            ValidateNonEmpty(lastName, "Invalid Data Entered!");
            bool isContactFound = false;

            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].Item1.ToLower() == firstName.ToLower() && contacts[i].Item2.ToLower() == lastName.ToLower())
                {
                    isContactFound = true;
                    WriteLine($"Enter a new phone number for {firstName} {lastName}:");
                    string phoneNumber = ReadLine();
                    contacts[i].Item3 = phoneNumber;
                    WriteLine("Contact After Update:");
                    ShowRow(contacts[i]);
                    break; // let's assume that there will be no contacts with same First Name and Last Name 
                }
            }
            if (!isContactFound)
            {
                throw new ContactNotFoundException("No Contacts Found With such First Name and Last Name!");
            }
            RewriteContacts(contacts);
        }
        catch (ArgumentException ae)
        {
            WriteLine(ae.Message);
        }
        catch (ContactNotFoundException cnfe)
        {
            System.Console.WriteLine(cnfe.Message);
        }
        MakeDelay();
    }
    static void RewriteContacts((string, string, string)[] contacts)
    {
        var csvBuilder = new StringBuilder();
        foreach (var contact in contacts)
        {
            csvBuilder.AppendLine(Serialize(contact));
        }

        File.WriteAllText(filename, csvBuilder.ToString());
    }
    static void MakeDelay()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }

    static void MainMenu()
    {
        Clear();

        WriteLine("Welcome to phone book!");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Show all contacts");
        WriteLine("\t2 - Add new contact");
        WriteLine("\t3 - Search contact");
        WriteLine("\t4 - Remove contact");
        WriteLine("\t5 - Update contact");
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
            case ConsoleKey.D3:
                SearchContact();
                break;
            case ConsoleKey.D4:
                RemoveContact();
                break;
            case ConsoleKey.D5:
                UpdateContact();
                break;
            default:
                break;
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                MainMenu();
            }
            catch (Exception e)
            {
                WriteLine($"Unhandled error: {e.Message}");
                ReadKey();
            }
        }
    }
}