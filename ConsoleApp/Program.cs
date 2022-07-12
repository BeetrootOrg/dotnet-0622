using ConsoleApp;

var votes = new List<Vote>();

void MainMenu()
{
    Console.Clear();
    System.Console.WriteLine("--Vote--");
    System.Console.WriteLine("1. Create Vote");
    System.Console.WriteLine("2. Vote for any topic");
    System.Console.WriteLine("3. Show results");
    System.Console.WriteLine("0. Exit");
    System.Console.WriteLine("Choise option: ");
    try
    {
        var choiseMainMenu = Console.ReadKey().Key;
        switch (choiseMainMenu)
        {
            case ConsoleKey.D1:
                Console.Clear();
                VoteCreator();
                break;

            case ConsoleKey.D2:
                Console.Clear();
                Voting();
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
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
};

void ShowResults()
{
    try
    {
        Console.Clear();
        System.Console.WriteLine("Choise vote");
        ShowVotes();
        var choiseShowResults = Console.ReadKey().Key;
        switch (choiseShowResults)
        {
            case ConsoleKey.D1:
                Console.Clear();
                System.Console.WriteLine("Result: Name Vote: '{0}'\n Vote first option:{1} Count votes:{2}\n Vote second option:{3} Count votes:{4}", votes[0].NameVote, votes[0].CommaSepratedChoise1, votes[0].Counter1, votes[0].CommaSepratedChoise2, votes[0].Counter2);
                break;
            case ConsoleKey.D2:
                Console.Clear();
                System.Console.WriteLine("Result: Name Vote: '{0}'\n Vote first option:{1} Count votes:{2}\n Vote second option:{3} Count votes:{4}", votes[1].NameVote, votes[1].CommaSepratedChoise1, votes[1].Counter1, votes[1].CommaSepratedChoise2, votes[1].Counter2);
                break;
            default:
                break;
        }
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
};

void Voting()
{
    Console.Clear();
    System.Console.WriteLine("Choise vote");
    ShowVotes();
    try
    {
        var choiseVoting = Console.ReadKey().Key;
        switch (choiseVoting)
        {
            case ConsoleKey.D1:
                Console.Clear();
                System.Console.WriteLine("You choise vote '{0}'", votes[0].NameVote);
                System.Console.WriteLine("Choise option: \n1.{0} \n2.{1}", votes[0].CommaSepratedChoise1, votes[0].CommaSepratedChoise2);
                var voteChoise1 = Console.ReadKey().Key;
                if (voteChoise1 == ConsoleKey.D1)
                {
                    votes[0].Counter1++;
                    break;
                }
                votes[0].Counter2++;
                break;

            case ConsoleKey.D2:
                Console.Clear();
                System.Console.WriteLine("You choise vote {0}", votes[1].NameVote);
                System.Console.WriteLine("Choise option: \n1.{0} \n2.{1}", votes[1].CommaSepratedChoise1, votes[1].CommaSepratedChoise2);
                var voteChoise2 = Console.ReadKey().Key;
                if (voteChoise2 == ConsoleKey.D1)
                {
                    votes[1].Counter1++;
                    break;
                }
                votes[1].Counter2++;
                break;

            default:
                break;
        }

    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }

};

void VoteCreator()
{
    try
    {
        System.Console.WriteLine("Enter vote name: ");
        var voteName = Console.ReadLine();
        System.Console.WriteLine("Enter comma-seprated:");
        string commaSepratedInput = Console.ReadLine();
        string[] output = commaSepratedInput.Split(',');
        try
        {
            votes.Add(new Vote
            {
                NameVote = voteName,
                CommaSepratedChoise1 = output[0],
                CommaSepratedChoise2 = output[1]
            });
        }
        catch (NullReferenceException nre)
        {
            System.Console.WriteLine(nre.Message);
        }
        System.Console.WriteLine("Vote created!");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
};

void ShowVotes()
{
    for (int i = 0; i < votes.Count; i++)
    {
        System.Console.WriteLine($"{i + 1}. {votes[i]}");
    }
};

while (true)
{
    MainMenu();
};