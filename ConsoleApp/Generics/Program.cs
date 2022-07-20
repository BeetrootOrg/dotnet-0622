using System;

namespace ConsoleApp;

class Program
{
    static private Vote _vote;
    static public void Main()
    {
        MainMenu();
    }

    static private void MainMenu()
    {
        System.Console.Clear();
        System.Console.WriteLine("Your Voting App");
        System.Console.WriteLine("Please, choose an option: ");
        System.Console.WriteLine("1. Create Vote");
        System.Console.WriteLine("2. Vote");
        System.Console.WriteLine("3. Show results");
        System.Console.WriteLine("0. Exit");

        try
        {
            var MainMenu = Console.ReadKey().Key;
            switch (MainMenu)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    CreateVote();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Vote();

                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    ShowResults();
                    break;

                case ConsoleKey.D0:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }
        catch (Exception exception)
        {
            System.Console.WriteLine(exception.Message);

        }

    }
    static private void CreateVote()
    {

        System.Console.WriteLine("Enter vote topic: ");
        var voteTopic = Console.ReadLine();
        var key = ConsoleKey.Y;

        _vote = new Vote(voteTopic);
        do
        {
            System.Console.WriteLine("Enter vote option: ");
            var inputOption = Console.ReadLine();
            _vote.AddOption(inputOption);
            System.Console.WriteLine("Would you like to enter another option? Y or N?");
            key = Console.ReadKey().Key;

        }
        while (key == ConsoleKey.Y);
        MainMenu();
    }

    static private void Vote()
    {
        if (_vote != null)
        {
            _vote.PrintVote();
            System.Console.WriteLine("Please choose your option");
            var chosenOptionIndex = Convert.ToInt32(Console.ReadLine());
            _vote.AddVote(chosenOptionIndex);

        }
        else
            System.Console.WriteLine("No vote is available.");

        MainMenu();

    }
    static private void ShowResults()
    {
        if (_vote != null)
        {
            _vote.PrintResults();
        }
        else
        {
            System.Console.WriteLine("The vote does not exist. Please create your vote first.");
        }
        System.Console.WriteLine("Press any key to proceed");
        System.Console.ReadKey();
        MainMenu();

    }

}








