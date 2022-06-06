// camel case name conv
// int simpleNumber = 42;
int a = 5;
int b = 6;
int sum = a + b;

Console.WriteLine(sum);
Console.WriteLine(a + b);
Console.WriteLine(a * b);

int c = 9;
int d = 4;
System.Console.WriteLine("Devide");
System.Console.WriteLine(c / d);
System.Console.WriteLine(d / c);
System.Console.WriteLine("Remaining");
System.Console.WriteLine(c % d);
System.Console.WriteLine(d % c);
// error below if you try to uncoment
// System.Console.WriteLine(100 / 0);

int i1 = 7;
byte b1 = 5;
short s1 = 6;
long l1 = 438493;
ulong l2 = 3433434;
uint i2 = 6;

System.Console.WriteLine(i1);
System.Console.WriteLine(b1);
System.Console.WriteLine(s1);
System.Console.WriteLine(l1);
System.Console.WriteLine(l2);
System.Console.WriteLine(i2);

//logical operations
bool first = true;
bool second = false;
bool third = true;
bool fourth = false;

System.Console.WriteLine ("Boolean");
System.Console.WriteLine (first);
System.Console.WriteLine (second);

System.Console.WriteLine ("logical not");
System.Console.WriteLine (!first);
System.Console.WriteLine (!second);

//if atleast one operand false - and equals to false

System.Console.WriteLine("logical AND");
System.Console.WriteLine(first && second);
System.Console.WriteLine(first && third);
System.Console.WriteLine(first && fourth);

//if atleast one operand true - or equals to true

System.Console.WriteLine("logical OR");
System.Console.WriteLine(second || first);
System.Console.WriteLine(second || third);
System.Console.WriteLine(second || fourth);

//complex operation
System.Console.WriteLine("Complex logical Operation");

// 1. (first || second)
// 2. (third || fourth)
// 3. ...&&...
System.Console.WriteLine((first || second) && (third || fourth));

// 1. second && third
// 2. first || ... || fourth
System.Console.WriteLine(first || second && third || fourth);

//bit operations
var var1 = 6; // 110
var var2 = 2; // 010
System.Console.WriteLine("Bitwise algebry");
System.Console.WriteLine(var1 & var2); // 110 & 010 -> 2
System.Console.WriteLine(var1 | var2); // 110 & 010 -> 2
System.Console.WriteLine(var1 ^ var2); // 110 & 010 -> 2
System.Console.WriteLine(var1 << var2); // 110 & 010 -> 2
System.Console.WriteLine(var1 >> var2); // 110 & 010 -> 2

System.Console.WriteLine("Increment");
//first we take var1 = 6; increment it to 7, write 7
System.Console.WriteLine(++var1);
//first we take var1 = 7; write 7; increment it to 8
System.Console.WriteLine(var1++);
//first we take var1 = 8; decrement it to 7; write 7
System.Console.WriteLine(--var1);
//first we take var1 = 7; write 7; decrement it to 6
System.Console.WriteLine(var1--);

//below is the same (almost)
var1 = var1 + 1;
var1 += 1;
var1++;

// I need to increment var1 by 10
var1 +=10; // the same as var1 = var1 + 10

float f3 = 135.45f;
double d3 = 135.45d;
decimal dd3 = 135.45m;

System.Console.WriteLine("Floats");
System.Console.WriteLine(f3);
System.Console.WriteLine(d3);
System.Console.WriteLine(dd3);

System.Console.WriteLine(12f / 5f);
System.Console.WriteLine(11f / 3f);