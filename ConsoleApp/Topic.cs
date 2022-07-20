using System;
using static System.Console;
namespace ConsoleApp;
using System.Linq;
using System.Collections.Generic;

public class Topic
{
    public string Tittle {get; init;}

    public Dictionary<string, int> VoteOptions {get; private set;} 

    public Topic(string tittle, string options)
    {
        Tittle = tittle;
        VoteOptions = new Dictionary<string, int>();

        var optionArr = options.Split(',');

        foreach (var option in optionArr)
        {
            VoteOptions.Add(option, 0);
        }

        WriteLine($"Topic \"{Tittle}\" added to voting system!");

        foreach(KeyValuePair<string, int> option in VoteOptions)
          {
              Console.WriteLine("{0}: {1} votes", option.Key, option.Value);
          }
    }

    public void AddVote (int optionNum)
    {
       string key = VoteOptions.Keys.ElementAt(optionNum - 1);
       VoteOptions[key]++;
    }

    public override string ToString()
    {   
        int total = 0;
        foreach (var option in VoteOptions)
        {
            total += option.Value;
        }

        if (total == 0 ) total = 1;

        string result = $"{Tittle} \n";
        int percents = 0;
        int num = 0;

        foreach (KeyValuePair<string, int> option in VoteOptions)
        {
            percents = option.Value * 100 / total;
            result += $"{++num} {option.Key} - {option.Value} votes ({percents}%) | ";
        }
        return result;

    }
} 
public class TopicList
{
    public List<Topic> Topics {get; init;}

    public TopicList()
    {
        Topics = new List<Topic>();
    }  

    public void AddTopic(Topic topic)
    {
        Topics.Add(topic);
    }

    public void ShowTopicList()
    {
        Console.WriteLine("Topics List:");
        if (Topics == null || Topics.Count == 0)
            Console.WriteLine ("No topics to vote");

        int i = 0;
        foreach (var topic in Topics)
            WriteLine($"{++i}  {topic}");
    }

    public Topic ShowTopicFromList(int key)
    {
        return Topics[key - 1];
    }
} 