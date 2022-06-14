using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
try
        {
             Console.WriteLine("Please enter X:");
            string xstring = Console.ReadLine();
            int x = int.Parse(xstring);

            Console.WriteLine("Please enter Y:");
            string ystring = Console.ReadLine();
            int y = int.Parse(ystring);
            int sum = 0 ;
    if (x!=y)
    { 
        if (x < y)
    {
    { 
        for ( int i = x; i <= y; i++ ) 
         sum += i;
    }
    System.Console.WriteLine($" The sum of all numbers between x and y: {sum} ");
        }

    else if (x > y)
    {
    {
        for ( int i = y; i <= x; i++ )
         sum += i;
    }
    System.Console.WriteLine($" The sum of all numbers between y and x: {sum} ");
    }
    }
    else 
    System.Console.WriteLine($" The sum of all numbers between x and y: {x} ");
            
        }
 catch (System.Exception)
        {
            System.Console.WriteLine($" Invalid output ");
            
            throw;
        }
        }
    }
}
