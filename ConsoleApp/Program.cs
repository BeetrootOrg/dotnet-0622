namespace ConsoleApp;
using System;
using static System.Console;

class Program
{
    private static void Main(string[] arg)
    {
        var menu = new Menu();
        menu.MainMenu();
        menu.СycleMenu();
    }
}