using System;
using System.IO;

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

void ShowAll()
{
    // 1. read content from file
    // 2. iterate in array of contacts
    // 3. show contact rows
    Clear();

    var contacts = new[]
    {
        ("First", "Last", "+3801234567"),
        ("F", "L", "+12039039"),
    };

    ShowRow(("First Name", "Last Name", "Phone"));
    foreach (var contact in contacts)
    {
        ShowRow(contact);
    }

    WriteLine("Press any key to continue...");
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

    File.WriteAllLines(filename, new[] { $"{firstName},{lastName},{phone}" });

    WriteLine("Contact saved, press any key to continue");
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
        default:
            break;
    }
}

while (true)
{
    MainMenu();
}