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
    var (FirstName, LastName, Phone) = row;
    WriteLine("{0,-15} {1,-15} {2,-15}", FirstName, LastName, Phone);
}

void ShowAll()
{
    Clear();
    var lines = File.ReadAllLines(filename);
    var contacts = new (string, string, string)[lines.Length];
    for (int a = 0; a < lines.Length; ++a)
    {
        var items = lines[a].Split(",");
        contacts[a] = (items[0], items[1], items[2]);
    }

    ShowRow(("FirstName", "LastName", "Phone"));
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

    File.AppendAllLines(filename, new[] { $"{firstName},{lastName},{phone}" });
    WriteLine("The contact has been saved.");
    WriteLine("Press any key to continue...");
    ReadKey();
}

void MainMenu()
{
    Clear();
    WriteLine("Welcome to phone book!");
    WriteLine();
    WriteLine("Menu:");
    WriteLine("\t1 - Show all contacs.");
    WriteLine("\t2 - Add new a contact.");
    WriteLine("\t3 - Update a contact.");
    WriteLine("\t4 - Remove a contact.");
    WriteLine("\t0 - Exit.");

    var key = ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D0:
            {
                Exit();
                break;
            }
        case ConsoleKey.D1:
            {
                ShowAll();
                break;
            }
        case ConsoleKey.D2:
            {
                AddNewContact();
                break;
            }
        default:
            {

                break;
            }
    }
}
while (true)
{
    MainMenu();
}