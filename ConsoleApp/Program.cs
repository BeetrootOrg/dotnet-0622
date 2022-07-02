using System;
using System.IO;
using System.Text;

using static System.Console;

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

    static (string, string, string)[] ReadContacts(string file)
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

    static void ShowAll()
    {
        // 1. read content from file
        // 2. iterate in array of contacts
        // 3. show contact rows
        Clear();

        var contacts = ReadContacts(filename);

        ShowRow(("First Name", "Last Name", "Phone"));
        foreach (var contact in contacts)
        {
            ShowRow(contact);
        }

        WriteLine("Press any key to continue...");
        ReadKey();
    }

    static string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

    static void AddNewContact()
    {
        Clear();

        WriteLine("Enter first name:");
        var firstName = ReadLine().Trim();

        WriteLine("Enter last name:");
        var lastName = ReadLine().Trim();

        WriteLine("Enter phone:");
        var phone = ReadLine().Trim();

        File.AppendAllLines(filename, new[] { Serialize((firstName, lastName, phone)) });

        WriteLine("Contact saved, press any key to continue");
        ReadKey();
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
            WriteLine("No Contacts Found!");
        }
        else
        {
            WriteLine($"{counter} {(counter == 1 ? "contact was" : "contacts were")} found");
        }
        WriteLine("Press any key to continue...");
        ReadKey();

    }
    static void UpdateContact()
    {
        Clear();
        var contacts = ReadContacts(filename);
        WriteLine("Provide Information About The Contact You Would Like To Update");
        WriteLine("First Name:");
        string firstName = ReadLine();
        WriteLine("Last Name:");
        string lastName = ReadLine();
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
        if (isContactFound)
        {
            RewriteContacts(contacts);
        }
        else
        {
            WriteLine("No Contacts Found With such First Name and Last Name!");
        }
        WriteLine("Press any key to continue...");
        ReadKey();
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
    private static void Main(string[] args)
    {


        while (true)
        {
            MainMenu();
        }
    }
}