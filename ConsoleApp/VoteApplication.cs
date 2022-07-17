using System.Text;

using static System.Console;

namespace ConsoleApp;

class VoteApplication
{
    private List<Vote> _votes = new List<Vote>();
    private const string filename = "data.csv";

    private void Exit()
    {
        Environment.Exit(0);
    }

    private List<Vote> ReadVotes(string file)
    {
        List<Vote> votes = new List<Vote>();;
        using (var stream = File.Open(file, FileMode.OpenOrCreate)) 
        {
            var streamReader = new StreamReader(stream, Encoding.UTF8);
            string content = streamReader.ReadToEnd();
            foreach(var line in content.Split("\n"))
            {
                if (line != "")
                {
                    var items = line.Split(';');
                    string voteName = items[0];
                    List<string> voteAnswerOptions = items[1].Split(',').ToList();
                    List<int> voteCount = items[2].Split(',').ToList().Select(s => Int32.Parse(s)).ToList();
                    votes.Add(new Vote(voteName, voteAnswerOptions, voteCount));
                }
            }
        }        
        return votes;
    } 

    private void CreateVote()
    {
        Clear();
        WriteLine("Enter vote topic:");
        var voteName = Console.ReadLine();

        WriteLine("Enter comma-separated options:");
        string answerOptions = ReadLine();
        
        List<string> answerOptionsList = answerOptions.Split(',').ToList();
        List<int> voteCount = new List<int>();
        for (int i = 0; i < answerOptionsList.Count(); i++)
            voteCount.Add(0);

        Vote newVote = new Vote(voteName, answerOptionsList, voteCount);
        File.AppendAllLines(filename, new[] {$"{newVote.GetName()};{String.Join(',',newVote.GetAnswerOptions())};{String.Join(',',newVote.GetVoteCount())}"});
        WriteLine("Vote was created, press any key to continue...");
        ReadKey();
    }

    private void VoteFor()
    {
        Clear();
        _votes = ReadVotes(filename);
        if (_votes.Count == 0)
        {
            WriteLine("There are no any vote yet");
            ReadKey();
            return;
        }
        
        int currentVote = ChooseTopic();

        Clear();
        WriteLine(_votes[currentVote].GetName());
        for (int i = 0; i < _votes[currentVote].GetAnswerOptions().Count(); i++)
        {
            WriteLine($"\t{i+1}. {_votes[currentVote].GetAnswerOptions()[i]}");
        }
        var answerOption = Int32.Parse(ReadLine())-1;
        _votes[currentVote].VoteFor(answerOption);
                

        var csvBuilder = new StringBuilder();
        foreach (var vote in _votes)
        {
            csvBuilder.AppendLine($"{vote.GetName()};{String.Join(',',vote.GetAnswerOptions())};{String.Join(',',vote.GetVoteCount())}");
        }
        File.WriteAllText(filename, csvBuilder.ToString());
        
    }

    private void VoteResults()
    {
        Clear();
        _votes = ReadVotes(filename);
        if (_votes.Count == 0)
        {
            WriteLine("There are no any vote yet");
            ReadKey();
            return;
        }

        int currentVote = ChooseTopic();

        Clear();
        WriteLine(_votes[currentVote].GetName());
        for (int i = 0; i < _votes[currentVote].GetAnswerOptions().Count(); i++)
        {
            WriteLine($"\t{i+1}. {_votes[currentVote].GetAnswerOptions()[i]} - {_votes[currentVote].GetVoteCount()[i]} vote(s)");
        }
        ReadKey();
    }

    private int ChooseTopic()
    {
        WriteLine("Choose topic:");
        for (int i = 0; i < _votes.Count(); i++)
        {
            WriteLine($"\t{i+1}. {_votes[i].GetName()}");
        }
        return Int32.Parse(ReadLine())-1;
    }

    private void MainMenu()
    {
        Clear();

        WriteLine("Welcome to vote application");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Create Vote");
        WriteLine("\t2 - Vote for something");
        WriteLine("\t3 - Show results");
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
                VoteFor();
                break;
            case ConsoleKey.D3:
                VoteResults();
                break;
            default:
                break;
        }
    }

    public void Run()
    {
        while (true)
        {
            try
            {
                MainMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled error: {e}");
                ReadKey();
            }
        } 
    }

}