using System;
using static System.Console;
namespace ConsoleApp;

class Program 
{
    public static void Main() 
    {
        char[,] myCells = new char [,] {{'*','.','*'},
                                        {'.','*','.'},
                                        {'*','*','.'}};
        
    var gameOfLife = new GameOfLife();
    foreach (char i in gameOfLife.Execute(myCells)) WriteLine(i);

    

    
        
    }
}