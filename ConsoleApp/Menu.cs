namespace ConsoleApp;
using System;
using System.Collections.Generic;

using static System.Console;

public class Menu : Vote
{
    void Exit()
    {
        Environment.Exit(0);
    }

    public void MainMenu()
    {
        Clear();
        WriteLine("Welcome to vote!");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Create Vote");
        WriteLine("\t2 - Vote for something");
        WriteLine("\t3 - Show Results");
        WriteLine("\t0 - Exit");

        var key = ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D0:
                Exit();
                break;
            case ConsoleKey.D1:
                CreateVote();
                break;
            case ConsoleKey.D2:
                VoteForsomething();
                break;
            case ConsoleKey.D3:
                ShowResults(ListTopic);
                break;
            default:
                break;
        }
    }
    public void СycleMenu()
    {
        while (true)
        {
            MainMenu();
        }
    }

}
