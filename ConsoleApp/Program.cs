System.Console.WriteLine("Enter first value");
var numberx = Console.ReadLine();
x = int.Parse(numberx);
if (int.TryParse(numberx, out x))

var y = 10;
var sum = 0;

if (x < y)
{
    for (int i = x; i <= y; i++)
    {
        sum += i;
    }
    System.Console.WriteLine($"sum = {sum}");
}
else if (x > y) 
{
    for (int i = y; i <= x; i++)
    {
       sum += i;
    } 
   System.Console.WriteLine($"sum = {sum}");
}
 