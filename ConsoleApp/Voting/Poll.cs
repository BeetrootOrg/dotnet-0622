namespace ConsoleApp.Voting;

class Poll
{
    public string Topic { get; init; }
    public Dictionary<int, Option> ListOfOptions { get; set; }
    public Poll() {}
    public Poll(string topic, Dictionary<int, Option> listOfOptions)
    {
        Topic = topic;
        ListOfOptions = listOfOptions;
    }
}