﻿using System;

using System.IO;

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
        var (FirstName, LastName, Phone) = row;
        WriteLine("{0,-15} {1,-15} {2,-15}", FirstName, LastName, Phone);
        WriteLine();
    }

    static void Show(string action, (string, string, string)[] result)
    {
        Clear();
        WriteLine($"{action}");
        WriteLine();
        if (result.Length > 0)
        {
            ShowRow(("FirstName", "LastName", "Phone"));
            foreach (var item in result)
            {
                ShowRow(item);
            }
            WriteLine("Press any key to continue...");
            ReadKey();
        }
        else
        {
            Show("Search for a contact in the phone book.", "The contact not found.");
            WriteLine();
        }
    }

    static void Show(string action, string result)
    {
        Clear();
        WriteLine($"{action}");
        WriteLine();
        WriteLine($"{result}");
        WriteLine();
        WriteLine("Press any key to continue...");
        ReadKey();
    }

    static (string, string, string)[] ReadContacts(string file)
    {
        var contacts = new (string, string, string)[0];
        if (File.Exists(file))
        {
            var lines = File.ReadAllLines(file);
            contacts = new (string, string, string)[lines.Length];
            for (int a = 0; a < lines.Length; ++a)
            {
                var items = lines[a].Split(",");
                contacts[a] = (items[0], items[1], items[2]);
            }
        }
        return contacts;
    }

    static bool WriteContacts(string file, string[] contacts)
    {
        if (File.Exists(file))
        {
            File.WriteAllLines(file, contacts);
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool WriteContacts(string file, (string, string, string)[] contacts)
    {
        string[] copy = new string[contacts.Length];

        for (int a = 0; a < contacts.Length; ++a)
        {
            copy[a] = $"{contacts[a].Item1},{contacts[a].Item2},{contacts[a].Item3}";
        }
        return WriteContacts(file, copy);
    }

    static void AddContact()
    {
        Clear();
        var contacts = ReadContacts(filename);
        WriteLine("Enter first name:");
        var firstName = ReadLine();

        WriteLine("Enter last name:");
        var lastName = ReadLine();

        WriteLine("Enter phone:");
        var phone = ReadLine();
        File.AppendAllLines(filename, new[] { $"{firstName},{lastName},{phone}" });
        Show("These contacts have been added.", new[] { (firstName, lastName, phone), });
    }

    static void RemoveContact()
    {
        int a = 0;
        int b = 0;

        Clear();
        WriteLine("Enter contact to remove:");
        var contactToRemove = ReadLine();
        var contacts = ReadContacts(filename);
        var removed = new (string, string, string)[contacts.Length];

        while (a < contacts.Length)
        {
            if (contacts[a].Item1 == contactToRemove ||
                contacts[a].Item2 == contactToRemove ||
                contacts[a].Item3 == contactToRemove)
            {
                removed[b] = contacts[a];
                ++b;
                contacts[a] = contacts[^1];
                Array.Resize(ref contacts, contacts.Length - 1);
            }
            else
            {
                ++a;
            }
            Array.Resize(ref removed, b + 1);
        }
        if (removed.Length > 0)
        {
            WriteContacts(filename, contacts);
            Show("These contacts have been deleted:", removed);
        }
        else
        {
            Show($"These contacts haven't been deleted:", contactToRemove);
        }
    }

    static (string, string, string)[] Search(int key, string value)
    {
        var contacts = ReadContacts(filename);
        var result = new (string, string, string)[contacts.Length];
        int a = 0;
        switch (key)
        {
            case 1:
                {
                    foreach (var contact in contacts)
                    {
                        if (contact.Item1 == value)
                        {
                            result[a] = contact;
                            ++a;
                        }
                    }
                    break;
                }
            case 2:
                {
                    foreach (var contact in contacts)
                    {
                        if (contact.Item2 == value)
                        {
                            result[a] = contact;
                            ++a;
                        }
                    }
                    break;
                }
            case 3:
                {
                    foreach (var contact in contacts)
                    {
                        if (contact.Item1 == value || contact.Item2 == value)
                        {
                            result[a] = contact;
                            ++a;
                        }
                    }
                    break;
                }
            case 4:
                {
                    foreach (var contact in contacts)
                    {
                        if (contact.Item3 == value)
                        {
                            result[a] = contact;
                            ++a;
                        }
                    }
                    break;
                }
        }
        Array.Resize(ref result, a);
        return result;
    }

    static int[] Search2(int key, string value)
    {
        var contacts = ReadContacts(filename);
        var result = new int[contacts.Length];
        int b = 0;
        switch (key)
        {
            case 1:
                {
                    for (int a = 0; a < contacts.Length; ++a)
                    {
                        if (contacts[a].Item1 == value)
                        {
                            result[b] = a;
                            ++b;
                        }
                    }
                    break;
                }
            case 2:
                {
                    for (int a = 0; a < contacts.Length; ++a)
                    {
                        if (contacts[a].Item2 == value)
                        {
                            result[b] = a;
                            ++b;
                        }
                    }
                    break;
                }
            case 3:
                {
                    for (int a = 0; a < contacts.Length; ++a)
                    {
                        if (contacts[a].Item1 == value || contacts[a].Item2 == value)
                        {
                            result[b] = a;
                            ++b;
                        }
                    }
                    break;
                }
            case 4:
                {
                    for (int a = 0; a < contacts.Length; ++a)
                    {
                        if (contacts[a].Item3 == value)
                        {
                            result[b] = a;
                            ++b;
                        }
                    }
                    break;
                }
        }
        Array.Resize(ref result, b);
        return result;
    }
    static void MenuSearch()
    {
        string message = string.Empty;
        Clear();
        WriteLine("Search for a contact in the phone book.");
        WriteLine("What contact to search?");
        WriteLine();
        string searchingElem = ReadLine();
        WriteLine();
        WriteLine("Search by:");
        WriteLine("\t1 - first name");
        WriteLine("\t2 - last name");
        WriteLine("\t3 - first or last name");
        WriteLine("\t4 - phone number");
        WriteLine("");
        WriteLine("\t0 - Back to main menu.");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                {
                    break;
                }
            case ConsoleKey.D1:
                {
                    message = "The result of searching for a contact by element bi first name:";
                    Show(message, Search(1, searchingElem));
                    break;
                }
            case ConsoleKey.D2:
                {
                    message = "The result of searching for a contact by element by last name:";
                    Show(message, Search(2, searchingElem));
                    break;
                }
            case ConsoleKey.D3:
                {
                    message = "The result of searching for a contact by element by first and last name:";
                    Show(message, Search(3, searchingElem));
                    break;
                }
            case ConsoleKey.D4:
                {
                    message = "The result of searching for a contact by item by phone number:";
                    Show(message, Search(4, searchingElem));
                    break;
                }
        }
    }

    static void MainMenu()
    {
        Clear();
        WriteLine("Welcome to phone book!");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Show all contacs.");
        WriteLine("\t2 - Add a new contact.");
        WriteLine("\t3 - Update a contact.");
        WriteLine("\t4 - Search a contact.");
        WriteLine("\t5 - Remove a contact.");
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
                    Show("Phone book:", ReadContacts(filename));
                    break;
                }
            case ConsoleKey.D2:
                {
                    AddContact();
                    break;
                }
            case ConsoleKey.D3:
                {
                    break;
                }
            case ConsoleKey.D4:
                {
                    MenuSearch();
                    break;
                }
            case ConsoleKey.D5:
                {
                    RemoveContact();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            Program.MainMenu();
        }
    }
}