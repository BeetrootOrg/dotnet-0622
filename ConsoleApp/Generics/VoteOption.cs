using System;

namespace ConsoleApp;
class VoteOption
{
    private string _text;
    private int _numberOfVotes = 0;
    public string Text { get => _text; }

    public int NumberOfVotes { get => _numberOfVotes; }

    public VoteOption(string inputText)
    {
        if (inputText != null && inputText.Length > 0)
            _text = inputText;
        else
        {

            throw new ArgumentException("Please enter valid vote option.");

        }

    }

    public void AddVote()
    {
        _numberOfVotes++;

    }



}







