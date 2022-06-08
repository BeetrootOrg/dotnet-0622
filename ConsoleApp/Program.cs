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

c = a > 40 && b >= 5 ? 15 : 10; // any dificult

System.Console.WriteLine("Loop For");
for (int i = 0; i < 10; ++i) //pre increment compiles faster than increment
{ 
    System.Console.WriteLine(i);
}

var sum = 0;
for(int  i = 0 ; i < 10; ++i)
{
    sum += i;
}
System.Console.WriteLine($"Sum from 0 to 9 equals = {sum}");

System.Console.WriteLine("Loop While");
int j = 0;
sum = 0;
while (j < 10)
{
 sum += j;
 ++j;
}
System.Console.WriteLine($"Sum is {sum}");

System.Console.WriteLine("Loop Do-While");
j = 0;
sum = 0;
do 
{
    sum += j;
    ++j;
} while(j < 10);
System.Console.WriteLine($"Sum is {sum}");

sum = 0;
for (int counter = 0; counter < 100; counter += 2)
{
    sum += counter;
}
System.Console.WriteLine(sum);

//2nd - option
sum = 0;

for (int counter = 0; counter < 100; counter += 2)
{
    if(counter % 2 != 0)
    {
        continue;
    }
    sum += counter;
}
System.Console.WriteLine(sum);

//3rd option
sum = 0;
j = 0;
while(j < 100)
{
    sum += j;
    j+=2;
}
System.Console.WriteLine(sum);

//4rd option
sum = 0;
j = 0;
/*while(j < 100)
{
    if(j%2 != 0)
    {
        continue;
    }
    sum += j;
    ++j;
}
System.Console.WriteLine(sum);*/

//5rd option
//sum = (0+100) / 2* 49;
//System.Console.WriteLine(sum);

System.Console.WriteLine("Input something: ");
var s = Console.ReadLine();
System.Console.WriteLine($"Input : {s}");

System.Console.WriteLine("Enter number: ");
var numberstr = Console.ReadLine();
System.Console.WriteLine($"Your number = {numberstr +42}");

var number = int.Parse(numberstr);
System.Console.WriteLine($"Your number = {number + 42}");

System.Console.WriteLine("enter number (please)");
numberstr = Console.ReadLine();
if(int.TryParse(numberstr, out number))
{
    System.Console.WriteLine($"You`ve entered number {number}");
}
else
{
    System.Console.WriteLine("Yo`re stupid");
}

bool result;
do
{
    System.Console.WriteLine("enter number (please)");
    numberstr = Console.ReadLine();
    result = int.TryParse(numberstr, out number);
}while (!result);