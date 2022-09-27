using System.Collections.Generic;

class Vote
{
    private static Vote _instance = null!;

    public List<Topic> Topics { get; private set; }

    public void Add(string topic)
    {
        if (Topics.FindIndex(top => top.Name == topic) == -1)
        {
            Topics.Add(new Topic(topic));
        }
    }

    public void AddRange(string[] topics)
    {
        foreach (var topic in topics)
        {
            if (topic != string.Empty)
            {
                Add(topic);
            }
        }
    }

    public void DoVote(int topic, bool choice)
    {
        if (choice)
        {
            ++Topics[topic].Yes;
        }
        else
        {
            ++Topics[topic].No;
        }
    }

    public string Show(int index)
    {
        return
            $"{Topics[index].Name}" + Environment.NewLine +
            $"1. Yes - {Topics[index].Yes} votes" + Environment.NewLine +
            $"2. No - {Topics[index].No} votes";
    }

    private Vote()
    {
        Topics = new List<Topic>();
    }

    public static Vote Instance()
    {
        if (_instance == null)
        {
            _instance = new Vote();
        }
        return _instance;
    }

}