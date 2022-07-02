using System;
using static System.Console;
namespace ConsoleApp;

class Program 
{
    public static void Main() 
    {
        char[,] myCells = new char [,] {{'*','.','*'},
                                        {'.','*','*'},
                                        {'*','*','.'}};
        
    GameOfLife.Execute(myCells);
        
    }
}