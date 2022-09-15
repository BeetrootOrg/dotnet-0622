using System.Collections.Generic;
using System.IO;
using System.Text;

using ConsoleApp;

List<Topic> grandList = new List<Topic>();
void Exit()
{
    Environment.Exit(0);
}

void MainMenu()
{
    Console.Clear();

    Console.WriteLine("Welcome!");
    Console.WriteLine();
    Console.WriteLine("Make your choise:");
    Console.WriteLine("1 - Create vote");
    Console.WriteLine("2 - Vote for something");
    Console.WriteLine("3 - Show Results");
    Console.WriteLine("4 - Exit");  a


    void TopicCreator()
    {
        Console.Clear();
        Console.WriteLine("Enter Topic Name");
        string _topicname = Console.ReadLine();
        Console.WriteLine("Enter coma-separated options");
        string commasepratedstring = Console.ReadLine();

        try
        {
            string[] output = commasepratedstring.Split(',');
            grandList.Add(new Topic
            {
                TopicName = _topicname,
                Variant1 = output[0],
                Variant2 = output[1]

            });
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Input correct coma separated options");
            Console.ReadLine();
        }

    }

    void TopicChooser()
    {
        Console.Clear();
        if (grandList.Count==0)
        {
            Console.WriteLine("Please, create a new topic");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Choose Topic");
        int tempcounter = 1;
        foreach (var topic in grandList)
        {
            Console.WriteLine($"{tempcounter}. {topic.TopicName}");
            tempcounter++;
        }
        var topicKey = Console.ReadKey();

        if (topicKey.Key != ConsoleKey.D1)
        {
            return;
        }
        Console.Clear();
        Console.WriteLine($"1. {grandList[0].Variant1}");
        Console.WriteLine($"2. {grandList[0].Variant2}");
        topicKey = Console.ReadKey();

        switch (topicKey.Key)
        {
            case ConsoleKey.D1:
                grandList[0].var1Counter++;
            break;
            case ConsoleKey.D2:
                grandList[0].var2Counter++;
                break;
        }
        tempcounter = 0;
    }

    void TopicResult()
    {
        Console.Clear();
        if (grandList.Count == 0)
        {
            Console.WriteLine("Please, create a new topic");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Choose Topic");
        int tempcounter = 1;
        foreach (var topic in grandList)
        {
            Console.WriteLine($"{tempcounter}. {topic.TopicName}");
            tempcounter++;
        }
        var topicKey = Console.ReadKey();
        if (topicKey.Key != ConsoleKey.D1)
        {
            return;
        }
            Console.Clear();
            Console.WriteLine($"1.{grandList[0].Variant1} - {grandList[0].var1Counter} votes");
            Console.WriteLine($"2.{grandList[0].Variant2} - {grandList[0].var2Counter} votes");
        Console.ReadKey();
    }

    var key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.D4:
            Exit();
            break;
        case ConsoleKey.D1:
            {
                TopicCreator();
            }
            break;
        case ConsoleKey.D2:
            {
                TopicChooser();
            }
            break;
        case ConsoleKey.D3:
            {
                TopicResult();
            }
            break;
    }
}


while (true)
{
    MainMenu();
}

