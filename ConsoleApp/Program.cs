var a = 45;

// if statments
if (a == 42)
{
    System.Console.WriteLine("a is 42");
}
else if (a == 43)
{
    System.Console.WriteLine("a is 43");
}
else if (a == 44)
{
System.Console.WriteLine("a is 44");
}
else 
{
    System.Console.WriteLine("a is unknown");
}

int b = 10;

if (a > 40 && b > 5)
{
    System.Console.WriteLine("a > 40 && b > 5");
}
else{
    System.Console.WriteLine("a > 40 && b > 5 is False");
}

if (a > 40 || b > 5)
{
    System.Console.WriteLine("a > 40 || b > 5");
}
else 
{
    System.Console.WriteLine("a > 40 || b > 5 is False");
}

switch (a)
{
    case 42:
        System.Console.WriteLine("a is 42");
        break;

    case 43:
        System.Console.WriteLine("a is 43");
        break;

    case 44:
        System.Console.WriteLine("a is 44");
        break;

    case 45:
        System.Console.WriteLine("a is 45");
        break;
    default:
    System.Console.WriteLine("a is unknown");
    break;
}

//if method
int c;
if(a == 45) c = 10;
else c = 5;

System.Console.WriteLine(c);

//terenar option
c = a == 45 ? 10 : 5;
c = a == 45 ? 10 : (a == 50 ? 15 : 5); // two cases
System.Console.WriteLine(c);

// third option - switch expression  (при присваивании значения)
c = a switch
{
    45 => 10,
    50 => 15,
    _ => 5
};

//4rd option - switch operator

switch(a)
{
    case 45:
    c = 10;
    break;

    default:
    c = 5;
    break;
}

c = a > 40 && b >= 5 ? 15 : 10; // 