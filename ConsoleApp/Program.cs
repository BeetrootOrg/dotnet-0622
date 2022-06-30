﻿using System;
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

void ShowAll()
{
    // 1. read content from file
    // 2. iterate in array of contacts
    // 3. show contact rows
    Clear();
    try
    {
        var contacts = ReadContacts(filename);
        ShowRow(("First Name", "Last Name", "Phone"));
        foreach (var contact in contacts)
        {
            ShowRow(contact);
        }
    }
    catch (FileNotFoundException)
    {
        System.Console.WriteLine("File " + filename + " don't exist");
    }

    WriteLine("Press any key to continue...");
    ReadKey();
}

string Serialize((string firstName, string lastName, string phone) row) => $"{row.firstName},{row.lastName},{row.phone}";

void AddNewContact()
{
    Clear();

    WriteLine("Enter first name:");
    var firstName = Console.ReadLine();

    WriteLine("Enter last name:");
    var lastName = Console.ReadLine();

    WriteLine("Enter phone:");
    var phone = Console.ReadLine();
    try
    {
        File.AppendAllLines(filename, new[] { Serialize((firstName, lastName, phone)) });

        WriteLine("Contact saved, press any key to continue");
    }
    catch
    {
        WriteLine("Contact don't saved, press any key to continue ");
    }
    ReadKey();
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

void SearchContact()
{
    Clear();

    try
    {
        var contacts = ReadContacts(filename);
        string stringForSearch = "";
        System.Console.WriteLine("Insert string for searching....and press Enter");
        var needSearch = System.Console.ReadLine();

        foreach (var contact in contacts)
        {
            stringForSearch = contact.ToString();
            if (stringForSearch.Contains(needSearch))
            {
                System.Console.WriteLine(contact);
            }
        }
    }
    catch (FileNotFoundException)
    {
        System.Console.WriteLine("File " + filename + " don't exist");
        System.Console.WriteLine("Press any key to continue... ");
    }


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
    WriteLine("\t5 - Search contact");
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
        default:
            break;
    }
}

while (true)
{
    MainMenu();
}