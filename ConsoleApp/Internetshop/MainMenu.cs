namespace ConsoleApp.Internetshop;
using static System.Console;
using System;
using System.IO;
using System.Text;


class MainMenu : IMeinMenu
{

    public void AdminMenu()
    {
        Clear();
        WriteLine();
        WriteLine("Please choose: ");
        WriteLine("\t1 - AddNewSkuToTheBase");
        WriteLine("\t2 - AddNewSkuToTheStore");
        WriteLine("\t0 - Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                WriteLine();
                ExitMenu();
                break;
            case ConsoleKey.D1:

                System.Console.WriteLine("AddNewSkuToTheBase");
                break;
            case ConsoleKey.D2:

                System.Console.WriteLine("AddNewSkuToTheStore");
                break;
        }
    }

    public void ClientMenu()
    {
        System.Console.WriteLine("ClientMenu");
    }

    public void ExitMenu()
    {
        Environment.Exit(0);
    }

    public void FirstMenu()
    {
        WriteLine("Welcome internet store");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Administrator access");
        WriteLine("\t2 - Client access");
        WriteLine("\t0 or ane key - Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                ExitMenu();
                break;
            case ConsoleKey.D1:
                AdminMenu();
                break;
            case ConsoleKey.D2:
                ClientMenu();
                System.Console.WriteLine("2");
                break;

            default:
                break;
        }
    }
}