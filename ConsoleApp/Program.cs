using System;
using static System.Console;
//namespace ConsoleApp;
using ConsoleApp;

class Program 
{
    public static void Main() 
    {
        char[,] field = new char [,]   {{'.','.','.','.','W','.','.','.'},
                                        {'.','.','.','.','W','.','.','.'},
                                        {'.','.','.','.','W','.','.','.'},
                                        {'.','.','.','B','W','.','.','.'},
                                        {'.','.','.','W','B','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'},
                                        {'.','.','.','.','.','.','.','.'}};
        
    var reversi = new Reversi();
    var output = new Output();

     output.Print2DArray(reversi.Execute(field, 'W'));
    
        
    }
}