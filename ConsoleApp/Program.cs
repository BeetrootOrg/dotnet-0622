int x, y;
int sum = 0;
bool checkParse;

do 
{
    System.Console.WriteLine("Enter first value:");
    var firstValue = Console.ReadLine();
    checkParse = int.TryParse(firstValue, out x);
    if (!checkParse) 
    {
        System.Console.WriteLine($"You have to enter number!");
    } 
}
    
while(!checkParse);

do 
{
    System.Console.WriteLine("Enter second value:");
    var secondValue = Console.ReadLine();
    checkParse = int.TryParse(secondValue, out y);
    if (!checkParse) 
    {
        System.Console.WriteLine($"You have to enter number!");
    }
}
while(!checkParse);

if (x < y)
{
    for(int i = x; i <= y; i++)
    {
     sum += i;
    }
}
else if (x == y) 
{
    sum = x;
}

else 
{
    for (int i = y; i <= x; i++)
    {
     sum += i;
    }
}

System.Console.WriteLine($"Sum of all numbers between values: {sum}");