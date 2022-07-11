namespace ConsoleApp;

class Vote
{
    public string Subject {get; init;}
    public string[] Options {get; init;}
    public int[] VotesForOptions{get; set;}

    public override string ToString()
    {
        string options = string.Join(", ", Options);
        string votesForOptions = string.Join(", ", VotesForOptions);
        return $"The voting subject is: {Subject} \n Options are: {options} \n Votes are: {votesForOptions}";
    }
    public void AddVote (Vote vote, int number)
    {
        vote.VotesForOptions[number]++;
    }
}