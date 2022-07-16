/*
Создать меню из нескольких пунктов
1) Greate VoteForSomething
Enter topic
--topic---
Enter comma-setareted options
yes. no
END

2) VoteForSomething for somethings
choose topic 
1) Topic 1
2) Topic 2
click 1
1 Yes
2 No
Click 2
1 Yes
2 No
END

3) Show results
Choose topic
1. Topic1
2. Topic2
Click 1 
1. Yes
2. No

0) Exit


*/
using static System.Console;
namespace ConsoleApp;

class MainMenu
{

    public void VoteForSomething()
    {
        WriteLine("VoteForSomeThing");
        
       // GetAnswers();

    }
    private void GreateVoteForSomething()
    {
        Clear();
        WriteLine();

        Question Myquestion = new Question();
        Myquestion.AddNewQuestion();
        FirstMenu();


    }

    public void ExitMenu()
    {
        Environment.Exit(0);
    }
    public void FirstMenu()
    {

        WriteLine("Menu:");
        WriteLine("\t1 - Greate VoteForSomething");
        WriteLine("\t2 - VoteForSomething for somethings");
        WriteLine("\t3 - Show results");
        WriteLine("\t0 or ane key - Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                System.Console.Clear();
                ExitMenu();
                break;
            case ConsoleKey.D1:// Greate VoteForSomething
                while (true)
                {
                    GreateVoteForSomething();
                }
                break;
            case ConsoleKey.D2:
                Clear();
                while (true)
                {
                    VoteForSomething();
                    WriteLine("number2");
                }
                break;
            case ConsoleKey.D3:
                Clear();
                while (true)
                {
                    //ClientMenu();
                    WriteLine("number3");
                }
                break;
            default:
                break;
        }
    }
}
