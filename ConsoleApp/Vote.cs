namespace ConsoleApp;

class Vote
{
    private string _name;
    private List<string> _answerOptions;
    private List<int> _voteCount;

    public void VoteFor(int option)
    {
        _voteCount[option]++;
    }

    public Vote(string name)
    {
        _name = name;
    }

    public Vote(string name, List<string> answerOptions)
    {
        _name = name;
        _answerOptions = answerOptions;
        _voteCount = new List<int>(_answerOptions.Count());
    }

    public Vote(string name, List<string> answerOptions, List<int> voteCount)
    {
        _name = name;
        _answerOptions = answerOptions;
        _voteCount = voteCount;
    }

    public string GetName()
    {
        return _name;
    }

    public List<string> GetAnswerOptions()
    {
        return _answerOptions;
    }

    public List<int> GetVoteCount()
    {
        return _voteCount;
    }

}