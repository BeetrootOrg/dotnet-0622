using System;
using System.Collections.Generic;
namespace ConsoleApp;

class Vote
{
    public string Topic { get; }
    public List<VoteOption> Options;

    public Vote(string inputText)
    {
        if (inputText != null && inputText.Length > 0)
            Topic = inputText;
        else
        {
            System.Console.WriteLine("Please enter valid vote topic.");
            throw new ArgumentException();

        }
    
    }
    public void AddOption (string optionText)
    {
        VoteOption option = new VoteOption(optionText);
    }
    


}
