/*
Создать меню из нескольких пунктов
1) Greate Vote
Enter topic
--topic---
Enter comma-setareted options
yes. no
END

2) Vote for somethings
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
using System.Console;

class MainMenu
{


    public void ExitMenu()
    {
        Environment.Exit(0);
    }
    public void FirstMenu()
    {
        System.Console.WriteLine("Welcome internet store");
        System.Console.WriteLine();
        System.Console.WriteLine("Menu:");
        System.Console.WriteLine("\t1 - Administrator access");
        System.Console.WriteLine("\t2 - Client access");
        System.Console.WriteLine("\t0 or ane key - Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                System.Console.Clear();
                ExitMenu();
                break;
            case ConsoleKey.D1:
                while (true)
                {
                    AdminMenu();
                }
                break;

            case ConsoleKey.D2:
                Clear();
                while (true)
                {
                    ClientMenu();
                }
                break;

            default:
                break;
        }
    }




}
