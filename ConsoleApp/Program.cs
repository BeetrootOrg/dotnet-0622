
byte b1 = 255;
short s1 = 10;
int i1 = 12;
long l1 = 20;
float f1 = 20.123f;
double d1 = 44.52d;
decimal dd1 = 251.553m;


System.Console.WriteLine("Task #1");
System.Console.WriteLine(b1 + s1);
System.Console.WriteLine(b1 + dd1);
System.Console.WriteLine(f1 * d1);
System.Console.WriteLine(b1 - f1);
System.Console.WriteLine(dd1 - b1);
System.Console.WriteLine(i1 + l1);
System.Console.WriteLine(b1 + s1 * l1 - dd1);

System.Console.WriteLine("Task #2");
var x = 3;
var y = 2;
System.Console.WriteLine(-6 * Math.Pow(x,3) + 5 * Math.Pow(x,2) - 10 * x + 15);
System.Console.WriteLine(Math.Abs(x) * Math.Sin(x));
System.Console.WriteLine( 2 * Math.PI * x);
System.Console.WriteLine(Math.Max(x,y));

