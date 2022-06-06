// See https://aka.ms/new-console-template for more information
// Camel case name convention
int a = 6;
int b = 5;
int sum = a + b;

Console.WriteLine(sum);
Console.WriteLine(a + b);
Console.WriteLine(a * b);

int c = 9;
int d = 4;

Console.WriteLine("Divide");
Console.WriteLine(c / d);
Console.WriteLine(d / c);
Console.WriteLine("Remaining");
Console.WriteLine(c % d);
Console.WriteLine(d % c);
// error below if you try to uncomment
// Console.WriteLine(100 / 0);

int i1 = 7;
byte b1 = 5;
short s1 = 6;
long l1 = 129030192;
ulong l2 = 129030192;
uint i2 = 6;

Console.WriteLine(i1);
Console.WriteLine(b1);
Console.WriteLine(s1);
Console.WriteLine(l1);
Console.WriteLine(l2);
Console.WriteLine(i2);

// Logical operations 
bool first = true;
bool second = false;
bool third = true;
bool fourth = false;

Console.WriteLine("Boolean");
Console.WriteLine(first);
Console.WriteLine(second);

Console.WriteLine("Logical NOT");
Console.WriteLine(!first);
Console.WriteLine(!second);

// If at least one operand false - ADD equals to false
Console.WriteLine("Logical ADD");
Console.WriteLine(first && second);
Console.WriteLine(first && third);
Console.WriteLine(first && fourth);

//  If at least one operand true - OR equals to true
Console.WriteLine("Logical OR");
Console.WriteLine(second || first);
Console.WriteLine(second || third);
Console.WriteLine(second || fourth);

// Complex logical operations

// 1. (first || second)
// 2. (second || fourth)
// 3. ... && ...
Console.WriteLine((first || second) && (third || fourth));

// 1. second && third
// 2. first || ... || fourth
Console.WriteLine(first || second && third || fourth);

// bit operations
var var1 = 6; // 110
var var2 = 2; // 010
Console.WriteLine("Bitwise algebra");
Console.WriteLine(var1 & var2); // 110 & 010 = 010 -> 2
Console.WriteLine(var1 | var2); // 110 | 010 = 110 -> 6
Console.WriteLine(var1 ^ var2); // 110 ^ 010 = 100 -> 4
Console.WriteLine(var1 << var2); // 110 << 2 = 11000 -> 24
Console.WriteLine(var1 >> var2); // 110 >> 2 = 001 -> 1

Console.WriteLine("Increment");
//  first we take var1 = 6; increment to 7, write 7
Console.WriteLine(++var1); // = 7
// first we take var1 = 7; increment to 8 
Console.WriteLine(var1++); // = 7
// first we take var1 = 8, decrement it to 7
Console.WriteLine(--var1); // = 7
// first we take var1 = 7, decrement it to 6
Console.WriteLine(var1--); // = 7

// below is the same (almost)
var1 = var1 + 1;
var1 += 1;
var1++;


// I need to increment var1 by 10
var1 += 10; // the same as var1 = var1 + 10

float f = 135.45f;
double dd2 = 135.45d;
decimal dd3 = 135.45m;

Console.WriteLine(f);
Console.WriteLine(dd2);
Console.WriteLine(dd3);

Console.WriteLine(12f / 5f);
Console.WriteLine(11f / 3f);

Console.WriteLine(+var1);
Console.WriteLine(-var1);

var nineteen = 19;
var twenty = 21;
Console.WriteLine("Equality");
Console.WriteLine(var1 == nineteen);
Console.WriteLine(var1 == twenty);
Console.WriteLine(var1 != nineteen);
Console.WriteLine(var1 != twenty);
Console.WriteLine("Greater");
Console.WriteLine(var1 > nineteen);
Console.WriteLine(var1 > twenty);
Console.WriteLine(var1 >= nineteen);
Console.WriteLine(var1 >= twenty);

Console.WriteLine("Math");
Console.WriteLine(Math.Abs(-42));
Console.WriteLine(Math.Abs(5));
Console.WriteLine(Math.Log10(100));
Console.WriteLine(Math.Cos(Math.PI));
Console.WriteLine(Math.Sin(Math.PI));

Console.WriteLine("Round positive");
Console.WriteLine(Math.Round(4.2));
Console.WriteLine(Math.Floor(4.2));
Console.WriteLine(Math.Ceiling(4.2));
Console.WriteLine(Math.Truncate(4.2));

Console.WriteLine("Round negative");
Console.WriteLine(Math.Round(-4.2));
Console.WriteLine(Math.Floor(-4.2));
Console.WriteLine(Math.Ceiling(-4.2));
Console.WriteLine(Math.Truncate(-4.2));