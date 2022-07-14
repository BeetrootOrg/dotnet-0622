namespace ConsoleApp.Internetshop;
using static System.Console;
// using System;
// using System.IO;
// using System.Text;



class Program : MainMenu
{
    static void Main(string[] args)
    {
        while (true)
        {
            MainMenu MyMenu = new MainMenu();
            MyMenu.FirstMenu();
        }
    }
}
