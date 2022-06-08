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

System.Console.WriteLine("Loop WHILE");
int j = 0;
sum = 0;
while (j < 10)
{
    sum += j;
    ++j;
}

System.Console.WriteLine($"Sum is {sum}");

while (sum < 0)
{
    System.Console.WriteLine("I'm inside");
}

System.Console.WriteLine("Loop DO-WHILE");
j = 0;
sum = 0;
do
{
    sum += j;
    ++j;
} while (j < 10);
System.Console.WriteLine($"Sum is {sum}");

do
{
    System.Console.WriteLine("I'm inside");
} while (sum < 0);

double d = 0.1 + 0.1 + 0.1;
float f = 0.1f * 0.1f * 0.1f;
System.Console.WriteLine(d);
System.Console.WriteLine(f);

// 1st option
sum = 0;
for (int counter = 0; counter < 100; counter += 2)
{
    sum += counter;
}

System.Console.WriteLine(sum);

// 2nd option
sum = 0;
for (int counter = 0; counter < 100; counter++)
{
    if (counter % 2 != 0)
    {
        continue;
    }

    sum += counter;
}

System.Console.WriteLine(sum);

// 3rd option
sum = 0;
j = 0;
while (j < 100)
{
    sum += j;
    j += 2;
}

System.Console.WriteLine(sum);

// 4th option
sum = 0;
j = 0;
while (++j < 100)
{
    if (j % 2 != 0)
    {
        continue;
    }

    sum += j;
}

System.Console.WriteLine(sum);

// 5th option
sum = (0 + 100) / 2 * 49;
System.Console.WriteLine(sum);

// console input
System.Console.WriteLine("Input something: ");
var s = Console.ReadLine();
System.Console.WriteLine($"Your input: {s}");

System.Console.WriteLine("Enter number: ");
var numberStr = Console.ReadLine();
System.Console.WriteLine($"Your number + 42 = {numberStr + 42}");

var number = int.Parse(numberStr);
System.Console.WriteLine($"Your number + 42 = {number + 42}");

System.Console.WriteLine("Enter number (please): ");
numberStr = Console.ReadLine();
if (int.TryParse(numberStr, out number))
{
    System.Console.WriteLine($"You've entered number {number}");
}
else
{
    System.Console.WriteLine("You're stupid");
}

bool result;
do
{
    System.Console.WriteLine("Enter number (please): ");
    numberStr = Console.ReadLine();
    result = int.TryParse(numberStr, out number);
} while (!result);