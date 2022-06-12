using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
     // Define several variables

      byte a = 126;
      short b = - 126;
      int c = 12;
      long d = 1234;
      bool bool1 = true;
      bool bool2 = false;
      float e = 7.52f;
      double f = 6.1d;
      decimal g = 12.22m;

    //   addition, subtraction, multiplication of several of them

System.Console.WriteLine(d - a);
System.Console.WriteLine(a + b);
System.Console.WriteLine(d / c);
System.Console.WriteLine(f * c);
System.Console.WriteLine( bool1 || bool2);

    //  result of several math functions


        int x = 5;
System.Console.WriteLine(-6*x^3+5*x^2-10*x+15);

        x = 100;
System.Console.WriteLine(Math.Abs(x)*Math.Sin(x));

        x = -11;
System.Console.WriteLine(2*Math.PI*x);

        x = 7;
        int y = 8;
         System.Console.WriteLine (Math.Max(x, y));

 var dateTime1 = new DateTime (2022,1,1);
 var dateTime2 = new DateTime (2023,1,1);
 var today = DateTime.Today;
 System.Console.WriteLine($"{(today - dateTime1).Days} days passed from New Year");
 System.Console.WriteLine($"{(dateTime2 - today).Days} days left to New Year");
  
        }
    }
}
