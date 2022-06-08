var a = 45;

if (a == 42)
{
    System.Console.WriteLine("A is 42");
}
else if (a == 43)
{
    System.Console.WriteLine("A is 43");
}
else if (a == 44)
{
    System.Console.WriteLine("A is 44");
}
else
{
    System.Console.WriteLine("A is unknown");
}

if (a == 42)
{
    System.Console.WriteLine("A is 42");
}
else if (a == 43)
{
    System.Console.WriteLine("A is 43");
}
else if (a == 44)
{
    System.Console.WriteLine("A is 44");
}
else
{
    System.Console.WriteLine("A is unknown");
}

if (a == 42)
{
    System.Console.WriteLine("A is 42");
}
else if (a == 43)
{
    System.Console.WriteLine("A is 43");
}
else if (a == 44)
{
    System.Console.WriteLine("A is 44");
}

int b = 10;
if (a > 40 && b > 10)
{
    System.Console.WriteLine("a > 40 && b > 10 = TRUE");
}
else
{
    System.Console.WriteLine("a > 40 && b > 10 = FALSE");
}

if (a > 40 || b > 10)
{
    System.Console.WriteLine("a > 40 || b > 10 = TRUE");
}
else
{
    System.Console.WriteLine("a > 40 || b > 10 = FALSE");
}

switch (a)
{
    case 42:
        System.Console.WriteLine("A is 42");
        break;
    case 43:
        System.Console.WriteLine("A is 43");
        break;
    case 44:
        System.Console.WriteLine("A is 44");
        break;
    default:
        System.Console.WriteLine("A is unknown");
        break;
}

// assign variable
// 1st option
int c;
if (a == 45) c = 10;
else if (a == 50) c = 15;
else c = 5;

System.Console.WriteLine(c);

// 2nd option - ternary
c = a == 45 ? 10 : (a == 50 ? 15 : 5);
System.Console.WriteLine(c);

// 3rd option - switch expression
c = a switch
{
    45 => 10,
    50 => 15,
    _ => 5
};

// 4rd option - switch operator
switch (a)
{
    case 45:
        c = 10;
        break;
    case 50:
        c = 15;
        break;
    default:
        c = 5;
        break;
}

c = a > 40 && b >= 5 ? 15 : 10;

// Error below
// a switch
// {
//     45 => Console.WriteLine("A"),
//     50 => Console.WriteLine("B"),
//     _ => Console.WriteLine("C")
// };

System.Console.WriteLine("Loop FOR");
for (int i = 0; i < 10; ++i)
{
    System.Console.WriteLine(i);
}

var sum = 0;
for (int i = 0; i < 10; ++i)
{
    sum += i;
}
System.Console.WriteLine($"Sum from 0 to 9 equals to {sum}");

// infinite loop below
// for (;;)
// {

// }

for (; sum < 50; sum += 3)
{
}

System.Console.WriteLine(sum);

// for (; ; ++sum)
// {
//     System.Console.WriteLine(sum);
// }

sum = int.MaxValue;
System.Console.WriteLine(sum + 1);
System.Console.WriteLine(sum - 1);