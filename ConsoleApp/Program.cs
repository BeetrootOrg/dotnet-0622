//Home work 

//enter paramiters

System.Console.WriteLine("Input first value: ");
int x;
int.TryParse(Console.ReadLine(), out x);

System.Console.WriteLine("Input second value: ");
int y;
int.TryParse(Console.ReadLine(), out y);

System.Console.WriteLine("Input therd value: ");
int z;
int.TryParse(Console.ReadLine(), out z);

System.Console.WriteLine("Input therd value: ");
int q;
int.TryParse(Console.ReadLine(), out q);



//Max Value from 2 number

static int MaxValuetwo(int a, int b) => (a > b) ? a : b;

System.Console.WriteLine($"Max value from two number {MaxValuetwo(x, y)}");

//Min value from 2 number

static int MinValuetwo(int a, int b) => (a < b) ? a : b;

System.Console.WriteLine($"Min value from two number {MinValuetwo(x, y)}");

//Max value from 3 number
static int MaxValuethre(int a, int b, int c) => a < b ? (b < c ? c : b) : (a < c ? c : a);

System.Console.WriteLine($"Max value from thre number {MaxValuethre(x, y, z)}");

//Min value from 3 number
static int MinValuethre(int a, int b, int c) => a > b ? (b > c ? c : b) : (a > c ? c : a);

System.Console.WriteLine($"Min value from three number {MinValuethre(x, y, z)}");

//Max value from 4 number
static int MaxValueFor(int a, int b, int c, int d)
{
    int m = 0;
    m = a > b ? a : b;
    m = m > c ? m : c;
    m = m > d ? m : d;
    return m;
}
System.Console.WriteLine($"Max value from for number {MaxValueFor(x, y, z, q)}");


//Min value from 4 number
static int MinValueFor(int a, int b, int c, int d)
{
    int m = 0;
    m = a < b ? a : b;
    m = m < c ? m : c;
    m = m < d ? m : d;
    return m;
}
System.Console.WriteLine($"Min value from for number {MinValueFor(x, y, z, q)}");

