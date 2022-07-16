namespace ConsoleApp.Voting;

class MainMenu
{
    private VotingApp _app;
    public MainMenu()
    {
        _app = new VotingApp();
    }

    public void MainMenuInterface()
    {
        Console.Clear();
        System.Console.WriteLine("Please Enter a Number To Procceed");
        System.Console.WriteLine("\t1. Create Vote");
        System.Console.WriteLine("\t2. Vote for something");
        System.Console.WriteLine("\t3. Show results");
        System.Console.WriteLine("\t0. Exit");

        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D1:
            _app.RegisterNewPoll();
            break;
            case ConsoleKey.D2:
            _app.VoteFor();
            break;
            case ConsoleKey.D3:
            _app.ShowResults();
            break;
            case ConsoleKey.D0:
            Environment.Exit(0);
            break;
            default:
            MainMenuInterface();
            break;
        }
    }
}