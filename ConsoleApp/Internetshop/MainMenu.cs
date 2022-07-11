namespace ConsoleApp.Internetshop;
using static System.Console;
using System;
using System.IO;
using System.Text;


class MainMenu : IMeinMenu
{
    public void ExitMenu()
    {
        Environment.Exit(0);
    }

    public void FirstMenu()
    {
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
                ExitMenu();
                break;
            case ConsoleKey.D1:
                // ShowAll();
                System.Console.WriteLine("1");
                break;
            case ConsoleKey.D2:
                //AddNewContact();
                System.Console.WriteLine("2");
                break;
            case ConsoleKey.D4:
                // RemoveContact();
                System.Console.WriteLine("4");
                break;
            case ConsoleKey.D5:
            System.Console.WriteLine("5");
                //  SearchContact();
                break;
            default:
                break;
        }
    }
}