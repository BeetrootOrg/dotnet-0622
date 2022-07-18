using System;

namespace ConsoleApp;
class VoteOption
{
    private string _text;
    private int _numberOfVotes = 0;
    public string Text { get => _text; }

    public VoteOption(string inputText)
    {
        if (inputText != null && inputText.Length > 0)
            _text = inputText;
        else
        {
            System.Console.WriteLine("Please enter valid vote option.");
            throw new ArgumentException();

        }

    }

    public void AddVote()
    {
        _numberOfVotes++;

    }



}







