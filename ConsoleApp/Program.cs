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
    Console.Clear();
    System.Console.WriteLine("Choise vote");
    ShowVotes();
    var choiseShowResults = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    System.Console.WriteLine("Result: Name Vote: '{0}'\n Vote first option: \t{1} Count votes:{2}\n Vote second option:\t{3} Count votes:{4}", votes[choiseShowResults - 1].NameVote, votes[choiseShowResults - 1].CommaSepratedChoise1, votes[choiseShowResults - 1].CounterOptions[choiseShowResults - 1], votes[choiseShowResults - 1].CommaSepratedChoise2, votes[choiseShowResults - 1].CounterOptions[choiseShowResults - 1]);
    Console.ReadKey();
};

void Voting()
{
    Console.Clear();
    System.Console.WriteLine("Choise vote");
    ShowVotes();
    var choiseVoting = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("You choise vote '{0}'", votes[choiseVoting - 1].NameVote);
    System.Console.WriteLine("Choise option: \n1.{0} \n2.{1}", votes[choiseVoting - 1].CommaSepratedChoise1, votes[choiseVoting - 1].CommaSepratedChoise2);
    var choiseVotingOption = Convert.ToInt32(Console.ReadLine());
    votes[choiseVoting - 1].AddVote(votes[choiseVoting - 1], choiseVotingOption - 1);
    System.Console.WriteLine("Vote add!");
    Console.ReadKey();
};

void VoteCreator()
{

    System.Console.WriteLine("Enter vote name: ");
    var voteName = Console.ReadLine();
    System.Console.WriteLine("Enter comma-seprated:");
    string commaSepratedInput = Console.ReadLine();
    string[] output = commaSepratedInput.Split(',');
    int[] sizeMass = new int[output.Length];

    votes.Add(new Vote
    {
        NameVote = voteName,

        CommaSepratedChoise1 = output[0],
        CommaSepratedChoise2 = output[1],
        CounterOptions = sizeMass

    });

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