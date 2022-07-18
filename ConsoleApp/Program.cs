using ConsoleApp;
using static System.Console;
//using System.Collections.Generic;

// class Program : MainMenu
// {


//     static void Main(string[] args)
//     {

// while (true)
// {
//     MainMenu MyMenu = new MainMenu();
//     MyMenu.FirstMenu();
// }
internal class Program
{
    private static void Main(string[] args)
    {
        Clear();
        var list = new LinkedList<int>();
        list.Add(1);
        WriteLine("1");
        list.Add(2);
        WriteLine("2");
        list.Add(3);
        WriteLine("3");
    }
}




//     }
// }