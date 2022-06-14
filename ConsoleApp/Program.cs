
 

System.Console.WriteLine("Input first value: ");
var nx = Console.ReadLine();
var x = int.Parse(nx);

System.Console.WriteLine("second value: ");
var xy = Console.ReadLine();
var y = int.Parse(xy);

System.Console.WriteLine("third value: ");
var xc = Console.ReadLine();
var c = int.Parse(xc);

/*System.Console.WriteLine("forth value: ");
var xd = Console.ReadLine();
var yd = int.Parse(xd);*/


//Max Value from 2 number

static int MaxValue(int a, int b)
{
    return (a > b) ? a : b;
}

System.Console.WriteLine($"Max value from two number {MaxValue(x, y)}");

//Min value from 2 number

static int MinValuetwo(int a, int b)
{
    return (a < b) ? a : b;
}

System.Console.WriteLine($"Min value from two number {MinValuetwo(x, y)}");


static int MaxValuethre(int a, int b, int c)
{
    if (MaxValue > c) return (c);
    return(MaxValue);
}

System.Console.WriteLine($"Max value from two number {MaxValuethre(x, y)}");