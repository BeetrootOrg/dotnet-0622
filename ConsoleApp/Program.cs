// camel case name convention
int a = 5;
int b = 6;
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
// error below if you try to uncoment
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

// logical operation
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

// if at least one operand false - AND equals to false
Console.WriteLine("Logical AND");
Console.WriteLine(first && second);
Console.WriteLine(first && third);
Console.WriteLine(first && fourth);

// if at least one operand true - OR equals to true
Console.WriteLine("Logical OR");
Console.WriteLine(second || first);
Console.WriteLine(second || third);
Console.WriteLine(second || fourth);

// complex operation
Console.WriteLine("Complex Logical Operation");

// 1. (first || second)
// 2. (third || fourth)
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
// first we take var1 = 6; increment it to 7; write 7
Console.WriteLine(++var1); // 7 7 7 -> right is 7
// first we take var1 = 7; write 7; increment it to 8
Console.WriteLine(var1++); // 6 7 7 -> right is 7
// first we take var1 = 8; decrement it to 7; write 7
Console.WriteLine(--var1); // 5 5 6 -> right is 7
// first we take var1 = 7; write 7; decrement it to 6
Console.WriteLine(var1--); // 6 5 6 -> right is 7

// below is the same (almost)
var1 = var1 + 1;
var1 += 1;
var1++;


// I need to increment var1 by 10
var1 += 10; // the same as var1 = var1 + 10

float f3 = 135.45f;
double d3 = 135.45;
decimal dd3 = 135.45m;

Console.WriteLine("Floats");
Console.WriteLine(f3);
Console.WriteLine(d3);
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