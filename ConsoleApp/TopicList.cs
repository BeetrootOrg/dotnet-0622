using System;
using static System.Console;
namespace ConsoleApp;

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
        Console.WriteLine("----------Topics List Here ----------");
        if (Topics == null || Topics.Count == 0)
            Console.WriteLine ("Your Topic list is empty, add some topics before!!!");
        
        int i = 0;
        foreach (var Topic in Topics)
            WriteLine($"{++i}  {Topic}");
    }
    
    public Topic ShowTopicFromList(int key)
    {
        return Topics[key - 1];
    }
}