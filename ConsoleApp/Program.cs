int x;
int y;

// Entering x
Console.WriteLine("Hello, let's do some loops, please enter whole number x:");

var console = Console.ReadLine();

if (int.TryParse(console, out x))
{
    Console.WriteLine("x="+ x);
} 
else 
{ 
Console.WriteLine("x is not an integer number, run again and put right value");
return;
}   

// Entering y
Console.WriteLine("Now enter whole number y:");

console = Console.ReadLine();

if (int.TryParse(console, out y))
{
    Console.WriteLine("y="+ y);
} 
else
{ 
Console.WriteLine("y is not an integer number, run again and put right value");
return;
}

int length;
length = (x > y) ? x - y : y - x; 
//Console.WriteLine($"Gonna be {length+1} iterations");

int sum = 0;

for (int i = 0; i <= length; i++)
{
    sum += (x > y) ? y++ : x++; 

}

Console.WriteLine($"The sum is {sum}");





