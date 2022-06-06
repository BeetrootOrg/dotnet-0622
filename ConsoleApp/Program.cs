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