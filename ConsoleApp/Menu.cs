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

  void CreateTopic()
  {
      Clear();
      WriteLine("Enter the new Vote Topic Tittle");
      string tittle = ReadLine();
      var topic = new Topic(tittle);
      topicList.AddTopic(topic);
      WriteLine("Press any key to continue...");
      ReadKey();
      MainMenu();
  }

    void DoVote()
  {
      Clear();
      WriteLine("Choose Topic to Vote");
      topicList.ShowTopicList();
      WriteLine("Plese, choose Topic you want to Vote...");
      var key = ReadKey();
      Writeline ("Press 1 in your want to say Yes!");
      Writeline ("Press 2 in your want to say No!");
      Writeline(topicList[key]);
      MainMenu();
  }
  
  
  public void MainMenu()
  {
      Clear();

      WriteLine("Welcome to vote system!");
      WriteLine();
      WriteLine("Menu:");
      WriteLine("\t1 - Create Vote");
      WriteLine("\t2 - Vote For Something");
      WriteLine("\t3 - Show Results");
      WriteLine("\t0 - Exit");

      var key = ReadKey();

      switch (key.Key)
      {
          case ConsoleKey.D0:
              Exit();
              break;
          case ConsoleKey.D1:
              CreateTopic();
              break;
          case ConsoleKey.D2:
              DoVote();
              break;
          case ConsoleKey.D3:
            //  ShowResults();
              break;    
          default:
              break;
      }
  }
}