using System;

using static System.Console;

void Exit()
{
    Environment.Exit(0);
}

void MainMenu()
{
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
        default:
            MainMenu();
            break;
    }
}

MainMenu();