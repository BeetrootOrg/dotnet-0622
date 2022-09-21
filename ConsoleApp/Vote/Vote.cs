
class Vote
{
    private static Vote _instance = null!;

    public List<Topic> Topics { get; private set; }

    // public void Create(Topic topic)
    // {
    //     Topics.Clear();
    //     Topics.Add(topic);
    // }

    // public void Create(Topic[] topics)
    // {
    //     Topics.Clear();
    //     foreach (var topic in topics)
    //     {
    //         Topics.Add(topic);
    //     }
    // }

    public void Add(Topic topic)
    {
        if (!Topics.Contains(topic))
        {
            Topics.Add(topic);
        }
    }

    public void AddRange(Topic[] topics)
    {
        foreach (var topic in topics)
        {
            Add(topic);
        }
    }

    public void DoVote(int topic, int choice)
    {
        ++Topics[topic].Choice[choice];
    }

    public string[] Show(int topic)
    {
        return new string[]
        {
            $"1. Yes - {Topics[topic].Choice[1]} votes",
            $"2. No - {Topics[topic].Choice[0]} votes"
        };
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