int a =5;
int b = 6;
int sum = a + b;

Console.WriteLine(a * b);
Console.WriteLine(a + b);

int c = 9;
int d = 4;

System.Console.WriteLine(c / d);
System.Console.WriteLine(d / c);

int i1 = 7;
byte b1 = 5;
short s1 = 6;
long l1 = 129021492;
long l2 = 544124;
uint i2 = 6;

//logical operation
bool first = true;
bool second = false;
bool third = true;
bool fourth = false;


System.Console.WriteLine("Logical NOT");
System.Console.WriteLine(!first);
System.Console.WriteLine(!second);

System.Console.WriteLine(first && second);
System.Console.WriteLine(first || second);
System.Console.WriteLine(third && fourth);


//bit operations

var var1 = 5; //101
var var2 = 2; //010

System.Console.WriteLine("Binar operations");
System.Console.WriteLine(var1 & var2);
System.Console.WriteLine(var1 | var2);
System.Console.WriteLine(var1 ^ var2);
System.Console.WriteLine(var1 << var2);
System.Console.WriteLine(var1 >> var2);

System.Console.WriteLine("Increment");
System.Console.WriteLine(++var1);
System.Console.WriteLine(var1++);
System.Console.WriteLine(--var1);
System.Console.WriteLine(var1--);


