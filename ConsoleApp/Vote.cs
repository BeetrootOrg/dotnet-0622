namespace ConsoleApp;



public class Vote
{
    public string NameVote { get; set; }
    public string CommaSepratedChoise1 { get; set; }
    public string CommaSepratedChoise2 { get; set; }

    public int[] CounterOptions { get; set; } 


    public void AddVote(Vote vote, int a)
    {
        vote.CounterOptions[a]++;
    }


    public override string ToString()
    {
        return $"'{NameVote}' {CommaSepratedChoise1}:{CommaSepratedChoise2}";
    }
}


