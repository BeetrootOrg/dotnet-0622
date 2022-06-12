//Enter X value

int x;
 System.Console.WriteLine($"Enter X please");
var numberx = Console.ReadLine();
if (int.TryParse(numberx, out x))
    {
        System.Console.WriteLine($"you X number {x}");
    }
    else
    {
        System.Console.WriteLine("Wrong, only number");
       return;   
    }
   
//Enter Y value

 int y;
System.Console.WriteLine($"Enter Y please");
var numbery = Console.ReadLine();
if (int.TryParse(numbery, out y))
    {
        System.Console.WriteLine($"you Y number {y}");
    }
    else
    {
        System.Console.WriteLine("Wrong, only number");
        return; 
    }

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
 