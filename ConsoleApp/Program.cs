// first case
int x = 10, y = 13;
int sum = 0;

System.Console.WriteLine($"x = {x} y = {y}");

if (x < y)
{
    for (int i = x; i <= y; ++i)
    {
        sum += i;
    }

    System.Console.WriteLine("In IF"); // to check, which condition works 
}
else if (x > y) // x = 5, y = 2
{
    for (int i = y; i <= x; ++i)
    {
        sum += i;
    }

    System.Console.WriteLine("In Else If"); // to check, which condition works 
}
else
{
    sum = x;
}

System.Console.WriteLine($"The sum of numbers from X to Y is {sum}");