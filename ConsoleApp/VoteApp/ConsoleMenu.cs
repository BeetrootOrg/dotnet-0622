using static System.Console;
namespace ConsoleApp.VoteApp;

class ConsoleMenu
{
    public List<Poll> PollList { get; set; } = new List<Poll>();
    public void AddPoll()
    {
        Clear();

        PollList.Add(Poll.CreatePoll());
    }
    public void Vote()
    {
        Poll number = ChoosePoll();
        WriteLine("Choose option");
        int counter = 0;
        foreach (var item in number.Options)
        {
            WriteLine($"{counter + 1}. {item.Key}");
            counter++;
        }
        var key = ReadKey();
        string temp = "";
        switch (key.Key)
        {
            case ConsoleKey.D1:
                temp = number.Options.ElementAt(0).Key;
                number.Options[temp]++;
                break;
            case ConsoleKey.D2:
                temp = number.Options.ElementAt(1).Key;
                number.Options[temp]++;
                break;
            case ConsoleKey.D3:
                temp = number.Options.ElementAt(2).Key;
                number.Options[temp]++;
                break;
            case ConsoleKey.D4:
                temp = number.Options.ElementAt(3).Key;
                number.Options[temp]++;
                break;
            default:
                throw new Exception("No such option");
        }
    }

    public void ShowResults()
    {
        Poll number = ChoosePoll();

        Clear();

        foreach (var item in number.Options)
        {
            WriteLine($"{item.Value} voted for: {item.Key}");
        }
        ReadKey();
    }
    public void MainMenu()
    {
        Clear();

        WriteLine("Welcome to Vote App");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Create Poll");
        WriteLine("\t2 - Vote for something");
        WriteLine("\t3 - Show results");
        WriteLine("\t0 - Exit");

        var key = ReadKey();

        switch (key.Key)
        {
            case ConsoleKey.D0:
                Environment.Exit(0);
                break;
            case ConsoleKey.D1:
                AddPoll();
                break;
            case ConsoleKey.D2:
                Vote();
                break;
            case ConsoleKey.D3:
                ShowResults();
                break;
            default:
                break;
        }
    }
    private Poll ChoosePoll()
    {
        Clear();

        WriteLine("Choose poll");
        for (int i = 0; i < PollList.Count; i++)
        {
            WriteLine($"{i + 1}. {PollList[i].Topic}");
        }

        var key = ReadKey();
        Poll number = new Poll();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                number = PollList[0];
                break;
            case ConsoleKey.D2:
                number = PollList[1];
                break;
            case ConsoleKey.D3:
                number = PollList[2];
                break;
            case ConsoleKey.D4:
                number = PollList[3];
                break;
            case ConsoleKey.D5:
                number = PollList[4];
                break;
            case ConsoleKey.D6:
                number = PollList[5];
                break;
            case ConsoleKey.D7:
                number = PollList[6];
                break;
            case ConsoleKey.D8:
                number = PollList[7];
                break;
            case ConsoleKey.D9:
                number = PollList[8];
                break;
            default:
                throw new Exception("No such option");
        }
        return number;
    }
}