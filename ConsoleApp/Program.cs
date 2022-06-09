
//Task #1
var x = 10;
var y = 13;
var sum = 0;
if (x > y)
{
    for(int i = y;  i < x; i++)
    {
        sum += i;
    }
    System.Console.WriteLine($"Sum of the elements from y to x equals = {sum}");
}
else if (x < y)
{
    for (int i = x; i < y; i++)
    {
        sum += i;
    }
    System.Console.WriteLine($"Sum of the elements from x to y equals = {sum}");
}
else 
{
 
    sum = x;
    System.Console.WriteLine($"Sum of the elements from y to x equals = {sum}");
}

//Task Extra
int x1,y1;
System.Console.WriteLine("Input X number, Please: ");
var s = Console.ReadLine();
if(!int.TryParse(s,out x1))
{
    System.Console.WriteLine("Error: Incorrect input (Number expected)");
}
else
{
    System.Console.WriteLine("Input Y number, Please: ");
    s = Console.ReadLine();
    if(!int.TryParse(s,out y1))
    {
        System.Console.WriteLine("Error: Incorrect input (Number expected) ");
    }
}