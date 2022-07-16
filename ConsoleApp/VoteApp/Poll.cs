using static System.Console;
namespace ConsoleApp.VoteApp;

class Poll
{
    public string Topic { get; set; }

    public Dictionary<string, int> Options { get; set; }

    public Poll(string topic, Dictionary<string, int> options)
    {
        Topic = topic;
        Options = options;
    }
    public Poll()
    {

    }
    public static Poll CreatePoll()
    {
        WriteLine("Please enter the topic of your poll");
        string topic = ReadLine();

        WriteLine("Please enter four values for your options");
        string options = ReadLine();

        List<string> temp = options.Split(",").ToList();
        if(temp.Count > 4)
        {
            throw new Exception("Invalid input");
        }
        Dictionary<string, int> values = new Dictionary<string, int>();
        for (int i = 0; i < temp.Count; i++)
        {
            values.Add(temp[i], 0);
        }
        return new Poll(topic, values);
    }
}