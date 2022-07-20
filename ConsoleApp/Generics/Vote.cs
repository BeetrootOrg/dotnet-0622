using System;
using System.Collections.Generic;
namespace ConsoleApp;

class Vote
{
    public string Topic { get; }
    public List<VoteOption> Options = new List<VoteOption>();

    public Vote(string inputText)
    {
        if (inputText != null && inputText.Length > 0)
            Topic = inputText;
        else
        {

            throw new ArgumentException("Please enter valid vote topic.");

        }

    }
    public void AddOption(string optionText)
    {
        VoteOption option = new VoteOption(optionText);
        Options.Add(option);
    }

    public void PrintVote()
    {
        System.Console.WriteLine(Topic);
        for (int i = 0; i < Options.Count; i++)
        {
            System.Console.WriteLine((i + 1) + "." + Options[i].Text);

        }

    }
    public void AddVote(int index)
    {
        var newIndex = index - 1;
        if (newIndex >= 0 && newIndex < Options.Count)
        {
            Options[newIndex].AddVote();
            System.Console.WriteLine("Thank you. Your vote has been added.");
            System.Console.WriteLine("Press any key to proceed");
            System.Console.ReadKey();

        }
        else
            System.Console.WriteLine("Your vote option does not exist. Choose a different one.");
    
    }
    public void PrintResults()
    {
        System.Console.WriteLine(Topic);
        for (int i = 0; i < Options.Count; i++)
        {
            System.Console.WriteLine((i+1) + "." + Options[i].Text + " : " + Options[i].NumberOfVotes);

        }

    }

}








