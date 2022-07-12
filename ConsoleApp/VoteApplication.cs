using System.Text;

using static System.Console;

namespace ConsoleApp;

class VoteApplication
{
    protected List<Vote> Votes = new List<Vote>();
    const string filename = "data.csv";

    void Exit()
    {
        Environment.Exit(0);
    }

    void ReadVotes(string file)
    {
        Votes.Clear();
        var lines = File.ReadAllLines(file);        
        for (int i = 0; i < lines.Length; i++)
        {
            var items = lines[i].Split(';');
            string voteName = items[0];
            List<string> voteOptionsList = items[1].Split(',').ToList();
            List<int> voteCount = items[2].Split(',').ToList().Select(s => Int32.Parse(s)).ToList();
            Votes.Add(new Vote(voteName, voteOptionsList, voteCount));
        }
    }

    void CreateVote()
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
        File.AppendAllLines(filename, new[] {$"{newVote.Name};{String.Join(',',newVote.AnswerOptions)};{String.Join(',',newVote.VoteCount)}"});
        ReadKey();
    }

    void VoteFor()
    {
        Clear();
        ReadVotes(filename);
        WriteLine("Choose topic:");
        for (int i = 0; i < Votes.Count(); i++)
        {
            WriteLine($"\t{i+1}. {Votes[i].Name}");
        }
        int currentVote = Int32.Parse(ReadLine())-1;

        Clear();
        WriteLine(Votes[currentVote].Name);
        for (int i = 0; i < Votes[currentVote].AnswerOptions.Count(); i++)
        {
            WriteLine($"\t{i+1}. {Votes[currentVote].AnswerOptions[i]}");
        }
        var answerOption = Int32.Parse(ReadLine())-1;
        Votes[currentVote].VoteFor(answerOption);
                

        var csvBuilder = new StringBuilder();
        foreach (var vote in Votes)
        {
            csvBuilder.AppendLine($"{vote.Name};{String.Join(',',vote.AnswerOptions)};{String.Join(',',vote.VoteCount)}");
        }
        File.WriteAllText(filename, csvBuilder.ToString());
        
    }

    void VoteResults()
    {
        Clear();
        ReadVotes(filename);
        WriteLine("Choose topic:");
        for (int i = 0; i < Votes.Count(); i++)
        {
            WriteLine($"\t{i+1}. {Votes[i].Name}");
        }
        int currentVote = Int32.Parse(ReadLine())-1;

        Clear();
        WriteLine(Votes[currentVote].Name);
        for (int i = 0; i < Votes[currentVote].AnswerOptions.Count(); i++)
        {
            WriteLine($"\t{i+1}. {Votes[currentVote].AnswerOptions[i]} - {Votes[currentVote].VoteCount[i]} vote(s)");
        }
        ReadKey();
    }

    public void MainMenu()
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
                Console.WriteLine($"Unhandled error: {e.Message}");
                ReadKey();
            }
        } 
    }

}