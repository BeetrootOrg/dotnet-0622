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