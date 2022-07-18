using System.Collections.Generic;
using System;
using static System.Console;
namespace ConsoleApp;

public class Vote
{
    public List<Topic> ListTopic = new List<Topic>();
    public void CreateVote()
    {
        Clear();
        WriteLine("---Enter topic---");
        string nameTopic = ReadLine();
        WriteLine("---Enter comma-separated options---");
        string options = ReadLine();
        string[] splitOption = options.Split(',');
        ListTopic.Add(new Topic
        {
            NameTopic = nameTopic,
            FirstTopic = splitOption[0],
            SecondTopic = splitOption[1]
        });
        WriteLine("Press any key...");
        ReadKey();
    }
    public void VoteForsomething()
    {
        Clear();
        WriteLine("---Choose Topic---");
        int counter = 1;
        foreach (var item in ListTopic)
        {
            WriteLine($"{counter} {item.NameTopic}");
            counter++;
        }
        var chooseKey = ReadKey();
        Clear();
        WriteLine($"1. {ListTopic[0].FirstTopic}");
        WriteLine($"2. {ListTopic[0].SecondTopic}");
        chooseKey = ReadKey();
        switch (chooseKey.Key)
        {
            case ConsoleKey.D1:
                ListTopic[0].FirstCounter++;
                break;
            case ConsoleKey.D2:
                ListTopic[0].SecondCounter++;
                break;
            default:
                break;
        }
        Clear();
        WriteLine("Press any key...");
        ReadKey();
    }
    public void ShowResults<T>(IEnumerable<T> collection)
    {
        Clear();
        WriteLine(string.Join("\n", collection));
        WriteLine("Press any key...");
        ReadKey();
    }
}