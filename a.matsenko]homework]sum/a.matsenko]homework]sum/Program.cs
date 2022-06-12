byte b1 = 12;
short s1 = -122;
int i1 = 32;
long l1 = 923337;
bool bfirst = true;
bool bsecond = false;
float f3 = 235.5f;
double d3 = 123.5d;
decimal dd3 = 444.4442m;

Console.WriteLine(b1 + s1);
Console.WriteLine(i1 * f3);
Console.WriteLine(b1 % i1);
Console.WriteLine(l1 / s1);

Console.WriteLine(bfirst && bsecond);
Console.WriteLine(!bfirst);
Console.WriteLine(bsecond || bfirst);


//Write to console result of several math functions:
var x = 34;
var y = 14;
Console.WriteLine(-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);

//abs(x)*sin(x)
Console.WriteLine(Math.Abs(x) * Math.Sin(x));
Console.WriteLine(2 * Math.PI * y);


//max(x,y)

Console.WriteLine(Math.Max(x, y));