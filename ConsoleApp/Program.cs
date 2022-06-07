// See https://aka.ms/new-console-template for more information
Console.WriteLine("Старт тест, змінні");
// simple variable
// int simpleNumber = 42;
Console.WriteLine("Sum");
int a = 5;
int b = 6;
int sum = a + b;
System.Console.WriteLine(sum);

// ділення. При цьому явне ділення на нуль буде помилка. Це єксепшн
int c = 9;
int d = 4;
Console.WriteLine("Divide");
System.Console.WriteLine(c / d);
System.Console.WriteLine(d / c);

Console.WriteLine("Remaining");
System.Console.WriteLine(c % d);
System.Console.WriteLine(d % c);

int i1 = 7;
byte b1 = 5;
short s1 = 6;
long l1 = 128349023;
ulong l2 = 128349023;
uint i2 = 6;

System.Console.WriteLine(i1);
System.Console.WriteLine(b1);
System.Console.WriteLine(s1);
System.Console.WriteLine(l1);
System.Console.WriteLine(l2);
System.Console.WriteLine(i2);


// logical operation
System.Console.WriteLine("Logical operations");
bool f1 = true;
bool f2 = false;
System.Console.WriteLine(f1);
System.Console.WriteLine(f2);