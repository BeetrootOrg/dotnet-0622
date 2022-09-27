using System;

using static System.Console;

public class ConsoleInterface
{
    private ConsoleKeyInfo _key;

    private int _index;
    private int _border;

    private Vote Vote { get; set; }

    public void MainMenu()
    {
        Clear();
        WriteLine("Welcome to Vote");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("1.Create Vote");
        WriteLine("2.Vote for something");
        WriteLine("3.Show results");
        WriteLine("0.Exit");
        _key = ReadKey();
        switch (_key.Key)
        {
            case ConsoleKey.D0:
                {
                    Exit();
                    break;
                }
            case ConsoleKey.D1:
                {
                    Create();
                    break;
                }
            case ConsoleKey.D2:
                {
                    DoVote();
                    break;
                }
            case ConsoleKey.D3:
                {
                    ShowTopics();
                    break;
                }
            default:
                {
                    _key = new ConsoleKeyInfo();
                    break;
                }
        }
    }

    public void Create()
    {
        Clear();
        WriteLine("Enter a list of topics separated by commas:");
        Vote.AddRange(ReadTopics());
    }

    static string[] ReadTopics()
    {
        return ReadLine()?.Split(',');
    }

    public void DoVote()
    {
        Clear();
        ShowTopicsMenu();
        if (_index > -1)
        {
            _key = ShowTopic("Choose a position.");

            if (_key.Key == ConsoleKey.D1)
            {
                ++Vote.Topics[_index].Yes;
            }
            if (_key.Key == ConsoleKey.D2)
            {
                ++Vote.Topics[_index].No;
            }
            ShowTopic("");
        }
    }

    public void ShowTopics()
    {
        ShowTopicsMenu();
        if (_index > -1)
        {
            ShowTopic("Press any key to return a main menu.");
        }
    }

    public void ShowTopicsMenu()
    {
        _index = 0;
        _border = 0;
        while (-1 < _index && _index < Vote.Topics.Count)
        {
            Clear();
            _border = Vote.Topics.Count - _index > 9 ? 9 : Vote.Topics.Count - _index;
            WriteLine($"A list of topics from {_index + 1} to {_index + _border} of {Vote.Topics.Count}");
            WriteLine();
            ShowPartTopics();
            WriteLine();
            WriteLine("{0,-6} {1,0}", $"1 to {_border}", " - Choose a topic");
            WriteLine("{0,-6} {1,0}", "0", " - Return to main menu");
            WriteLine("{0,-6} {1,0}", "Enter", " - For next topics.");
            _key = ReadKey();
            if (_key.KeyChar > 48 && _key.KeyChar <= 57)
            {
                _index = -1 * (_index - _border + _key.KeyChar - 48);
            }
            else if (_key.KeyChar == 48)
            {
                _index = Vote.Topics.Count;
            }
            else if (_key.Key != ConsoleKey.Enter)
            {
                _index -= 9;
            }
        }
        ++_index;
        _index *= -1;
    }

    public void ShowPartTopics()
    {
        if (_index > -1)
        {
            for (int a = 0; _index < Vote.Topics.Count && a < _border; ++a)
            {
                WriteLine($"{a + 1}. {Vote.Topics[_index].Name}");
                ++_index;
            }
        }
    }

    public ConsoleKeyInfo ShowTopic(string massege)
    {
        Clear();
        WriteLine(Vote.Show(_index));
        WriteLine(massege);
        return ReadKey();
    }

    static void Exit()
    {
        Environment.Exit(0);
    }

    internal ConsoleInterface(ref Vote vote)
    {
        Vote = vote;
        _key = new ConsoleKeyInfo();
    }

}