using System;
using static System.Console;
namespace ConsoleApp;
using ConsoleApp;

public class Menu 
{

  TopicList topicList = new TopicList();

  void Exit()
  {
      Environment.Exit(0);
  }

  void AddTopic()
  {
      Clear();
      WriteLine("Enter Title of vote topic that you want to add");
      string tittle = ReadLine();
      WriteLine("If you want to add several options, please separate them with comma");
      string options = ReadLine();
      var topic = new Topic(tittle, options);
      topicList.AddTopic(topic);
      WriteLine("Press any key to continue");
      ReadKey();
      MainMenu();
  }

    void DoVote()
  {
      Clear();
      WriteLine("Choose Topic to Vote");
      topicList.ShowTopicList();
      WriteLine("Plese, choose Topic you want to Vote: ");
      var console = ReadLine();

      if (!int.TryParse(console, out int key))
        { 
          Console.WriteLine("Please, enter only number. Restart and try again!");
        }
      WriteLine ("Put the number of options you want to Vote for");
      var topicToVote = topicList.ShowTopicFromList(key);

      topicToVote.ToString();
      console = ReadLine();
      if (!int.TryParse(console, out key))
        { 
          Console.WriteLine("Please, enter only number. Restart and try again!");
        }

      topicToVote.AddVote(key);
      WriteLine("Thanks for your vote! Press any key to continue");
      ReadKey();
      MainMenu();
  }

  void ShowResults()
  {
    Clear();
    topicList.ShowTopicList();
    WriteLine("Press any key to continue");
    ReadKey();
    MainMenu();

  }

  public void MainMenu()
  {
      Clear();
      WriteLine("Welcome to vote system!");
      WriteLine();
      WriteLine("Menu:");
      WriteLine("\t1 - Create Vote");
      WriteLine("\t2 - Voting Choice");
      WriteLine("\t3 - Show Results");
      WriteLine("\t0 - Exit");

      var key = ReadKey();

      switch (key.Key)
      {
          case ConsoleKey.D0:
              Exit();
              break;
          case ConsoleKey.D1:
              AddTopic();
              break;
          case ConsoleKey.D2:
              DoVote();
              break;
          case ConsoleKey.D3:
              ShowResults();
              break;    
          default:
              break;
      }
  }
} 