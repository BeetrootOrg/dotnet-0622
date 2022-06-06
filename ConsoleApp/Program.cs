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
System.Console.WriteLine(c / d);
System.Console.WriteLine(d / c);
System.Console.WriteLine("Remaining");
System.Console.WriteLine(c % d);
System.Console.WriteLine(d % c);
// error below if you try to uncomment
// System.Console.WriteLine(100 / 0);

int i1 = 7;
byte b1 = 5;
short s1 = 6;
long l1 = 129030192;
ulong l2 = 129030192;
uint i2 = 6;

// Logical operations 
bool first = true;
bool second = false;
bool third = true;
bool fourth = false;

System.Console.WriteLine("Logical not");
System.Console.WriteLine(!first);
System.Console.WriteLine(!second);

// If at least one operand false - ADD equals to false
System.Console.WriteLine("Logical ADD");
System.Console.WriteLine(first & second);
System.Console.WriteLine(first && third);
System.Console.WriteLine(first && fourth);

//  If at least one operand true - OR equals to true
System.Console.WriteLine("Logical OR");
System.Console.WriteLine(second || first);
System.Console.WriteLine(second || third);
System.Console.WriteLine(second || fourth);