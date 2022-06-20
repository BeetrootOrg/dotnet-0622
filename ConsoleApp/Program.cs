using System;

using static System.Console;

void Exit()
{
    Environment.Exit(0);
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

    WriteLine("{0,-15} {1,-15} {2,-15}", "First Name", "Last Name", "Phone");
    foreach (var (firstName, lastName, phone) in contacts)
    {
        WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
    }

    WriteLine("Press any key to continue...");
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
        default:
            break;
    }
}

while (true)
{
    MainMenu();
}