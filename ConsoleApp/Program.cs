var a = 42;

if(a == 42)
{
    Console.WriteLine("A is 42");
}
else if (a == 43)
{
    Console.WriteLine ("A is 43");
}
else if (a == 44)
{
    Console.WriteLine ("A is 44");
}
else
{
    Console.WriteLine ("A is unknown");
}

if(a == 42)
{
    Console.WriteLine("A is 42");
}
else if (a == 43)
{
    Console.WriteLine ("A is 43");
}
else if (a == 44)
{
    Console.WriteLine ("A is 44");
}

int b = 10;
if (a > 40 && b > 10)
{
    Console.WriteLine("a>40 && b>10 is TRUE");
}

switch (a)
{
    case 42:
        Console.WriteLine("A is 42");
        break;
    
    default:
        Console.WriteLine ("A is unknown");
        break;
}

int c;
if (a == 45) c = 10;
else c = 5;

System.Console.WriteLine("c="+c);

//2nd option
c = a == 45 ? 10 : 5;

//3rd option switch expressor
c = a switch
{
    45 => 10,
    _=> 5
};

//4th option

switch(a)
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

int sum = 0;
for (; sum < 50; sum +=3)
{
    
}
Console.WriteLine (sum);

// let's make mess
sum = int.MaxValue;
Console.WriteLine (sum + 1);
Console.WriteLine (sum - 1);

int j = 0;
sum = 0;
while (j < 10)
{
    sum += j;
    ++j;
}

Console.WriteLine ($"Sum is {sum}");


j = 0;
sum = 0;
do {
    sum += j;
    ++j;
} while (j <10);
Console.WriteLine ($"Sum is {sum}");

float f = 0.1f * 0.1f * 0.1f;
double d = 0.1 + 0.1 + 0.1;
Console.WriteLine(d);
Console.WriteLine(f);
