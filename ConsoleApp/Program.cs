/* HOME TASK
Define several variables in your program (byte, short, int, long, bool, float, double, decimal) and write to console the result of addition, subtraction, multiplication 
of several of them.
Write to console result of several math functions:

-6*x^3+5*x^2-10*x+15
abs(x)*sin(x)
2*pi*x
max(x, y)

*/
// Start * HomeWokr 1Part *





// Start *Homework Math* 
System.Console.WriteLine("Start Homework Math");
//variables x and y
int x = 51;
int y = 65;

System.Console.WriteLine("x="+x);
System.Console.WriteLine("y="+y);

//Result1 -6*x^3+5*x^2-10*x+15
System.Console.WriteLine("------- -6*x^3+5*x^2-10*x+15");
System.Console.WriteLine(-6*Math.Pow(x, 3)+5*Math.Pow(x, 2)-10*x+15);

//Result2 abs(x)*sin(x)
System.Console.WriteLine("------- abs(x)*sin(x) --");
System.Console.WriteLine(Math.Abs(x)*Math.Sin(x));

//Result3 2*pi*x
System.Console.WriteLine("------- 2*pi*x ---------");
System.Console.WriteLine(2*Math.PI*x);

//Result4 max(x, y)
System.Console.WriteLine("------- max(x, y) ------");
System.Console.WriteLine(Math.Max(x, y));


