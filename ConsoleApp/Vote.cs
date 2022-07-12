namespace ConsoleApp;

class Vote
{
    public string Name { get; init; }

    public List<string> AnswerOptions {get; protected init;}
    public List<int> VoteCount {get; protected set;}

    public void VoteFor(int option)
    {
        VoteCount[option]++;
    }

    public Vote(string name)
    {
        Name = name;
    }

    public Vote(string name, List<string> answerOptions)
    {
        Name = name;
        AnswerOptions = answerOptions;
        VoteCount = new List<int>(AnswerOptions.Count());
    }

    public Vote(string name, List<string> answerOptions, List<int> voteCount)
    {
        Name = name;
        AnswerOptions = answerOptions;
        VoteCount = voteCount;
    }

}