// camel case name convention
int a = 5;
int b = 6;
int sum = a + b;

Console.WriteLine(sum);
Console.WriteLine(a + b);
Console.WriteLine(a * b);

int c = 9;
int d = 4;
System.Console.WriteLine("Divide");
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
long l1 = 129030192;
ulong l2 = 129030192;
uint i2 = 6;

System.Console.WriteLine(i1);
System.Console.WriteLine(b1);
System.Console.WriteLine(s1);
System.Console.WriteLine(l1);
System.Console.WriteLine(l2);
System.Console.WriteLine(i2);

// logical operation
bool first = true;
bool second = false;
bool third = true;
bool fourth = false;

System.Console.WriteLine("Boolean");
System.Console.WriteLine(first);
System.Console.WriteLine(second);

System.Console.WriteLine("Logical NOT");
System.Console.WriteLine(!first);
System.Console.WriteLine(!second);

// if at least one operand false - AND equals to false
System.Console.WriteLine("Logical AND");
System.Console.WriteLine(first && second);
System.Console.WriteLine(first && third);
System.Console.WriteLine(first && fourth);

// if at least one operand true - OR equals to true
System.Console.WriteLine("Logical OR");
System.Console.WriteLine(second || first);
System.Console.WriteLine(second || third);
System.Console.WriteLine(second || fourth);

// complex operation
System.Console.WriteLine("Complex Logical Operation");

// 1. (first || second)
// 2. (third || fourth)
// 3. ... && ...
System.Console.WriteLine((first || second) && (third || fourth));

// 1. second && third
// 2. first || ... || fourth
System.Console.WriteLine(first || second && third || fourth);

// bit operations
var var1 = 6; // 110
var var2 = 2; // 010
System.Console.WriteLine("Bitwise algebra");
System.Console.WriteLine(var1 & var2); // 110 & 010 = 010 -> 2
System.Console.WriteLine(var1 | var2); // 110 | 010 = 110 -> 6
System.Console.WriteLine(var1 ^ var2); // 110 ^ 010 = 100 -> 4
System.Console.WriteLine(var1 << var2); // 110 << 2 = 11000 -> 24
System.Console.WriteLine(var1 >> var2); // 110 >> 2 = 001 -> 1

System.Console.WriteLine("Increment");
// first we take var1 = 6; increment it to 7; write 7
System.Console.WriteLine(++var1); // 7 7 7 -> right is 7
// first we take var1 = 7; write 7; increment it to 8
System.Console.WriteLine(var1++); // 6 7 7 -> right is 7
// first we take var1 = 8; decrement it to 7; write 7
System.Console.WriteLine(--var1); // 5 5 6 -> right is 7
// first we take var1 = 7; write 7; decrement it to 6
System.Console.WriteLine(var1--); // 6 5 6 -> right is 7

// below is the same (almost)
var1 = var1 + 1;
var1 += 1;
var1++;


// I need to increment var1 by 10
var1 += 10; // the same as var1 = var1 + 10