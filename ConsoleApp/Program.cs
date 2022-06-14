//Home work 

System.Console.WriteLine("Input first value: ");
int x;
int.TryParse(Console.ReadLine(), out x);

System.Console.WriteLine("Input second value: ");
int y;
int.TryParse(Console.ReadLine(), out y);

System.Console.WriteLine("Input therd value: ");
int z;
int.TryParse(Console.ReadLine(), out z);


/*System.Console.WriteLine("forth value: ");
var xd = Console.ReadLine();
var yd = int.Parse(xd);*/cd


//Max Value from 2 number

static int MaxValuetwo(int a, int b)
{
    return (a > b) ? a : b;
}

System.Console.WriteLine($"Max value from two number {MaxValuetwo(x, y)}");

//Min value from 2 number

static int MinValuetwo(int a, int b)
{
    return (a < b) ? a : b;
}

//Max value from 3 number

System.Console.WriteLine($"Min value from two number {MinValuetwo(x, y)}");

static int MaxValuethre(int a, int b, int c)
{
 int MaxV = 0;

    MaxV = a > b ? a : b;
    MaxV = MaxV > c ? MaxV : c;
    return MaxV;

}

System.Console.WriteLine($"Max value from thre number {MaxValuethre(x, y, z)}");

static int MinValuethre(int a, int b, int c)
{
    if ( a > b & b > c) return c;
    if ()
}
System.Console.WriteLine($"Max value from thre number {MinValuethre(x, y, z)}");