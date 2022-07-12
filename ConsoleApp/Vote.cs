namespace ConsoleApp;



public class Vote
{
    List<string> ListCommaSepratedChoise = new List<string>();
    public string NameVote { get; set; }
    public string CommaSepratedChoise1 { get; set; }
    public string CommaSepratedChoise2 { get; set; }

    public int Counter1 { get; set; } = 0;
    public int Counter2 { get; set; } = 0;


    public override string ToString()
    {
        return $"'{NameVote}' {CommaSepratedChoise1}:{CommaSepratedChoise2}";
    }
}


