// Integral Numeric types
byte a = 8;
short b = 56;
int c = 451318;
long d = 1598798;

System.Console.WriteLine("Arithmetic operations with integral numeric types");
System.Console.WriteLine(a + c);
System.Console.WriteLine(b - c);
System.Console.WriteLine(d * a);
System.Console.WriteLine(c * a);

// floating-point numeric types
float e = 2.102f; 
double f = 3.516;
decimal j = 31.47482m;

System.Console.WriteLine("Arithmetic operations with floating-point numeric types");
System.Console.WriteLine(e + f);
System.Console.WriteLine(e - f);
System.Console.WriteLine ((decimal)j * (decimal)f);

bool first = true;
bool second = false;

System.Console.WriteLine("Logical operations");
System.Console.WriteLine(first && second);


System.Console.WriteLine("several math functions");

var x = 13;
var y = 7;

System.Console.WriteLine(-6 * Math.Pow(x,3) + 5 * Math.Pow(x,2) - 10 * x + 15);
System.Console.WriteLine(Math.Abs(x) * Math.Sin(x));
System.Console.WriteLine(2 * Math.PI * x);
System.Console.WriteLine(Math.Max(x, y));
