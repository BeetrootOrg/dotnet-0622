internal class Program
{
    // 1st part of the task
    static int MaxValueAmong(int a, int b) => a >= b ? a : b;
    static int MaxValueAmong(int a, int b, int c) => MaxValueAmong(MaxValueAmong(a, b), c);

    static int MaxValueAmong(int a, int b, int c, int d) => MaxValueAmong(MaxValueAmong(a, b), MaxValueAmong(c, d));
    // second part of the task
    static int MinValueAmong(int a, int b) => a >= b ?  b :  a;
    static int MinValueAmong(int a, int b, int c) => MinValueAmong(MinValueAmong(a, b), c);
    static int MinValueAmong(int a, int b, int c, int d) => MinValueAmong(MinValueAmong(a, b), MinValueAmong(c, d));

    //third part of the task

    static int SumBetweenNumbers(int a, int b)
    {
        int sumBetween = 0;
        if (a <= b)
        {
            for (int i = a; i <= b; ++i)
            {
                sumBetween += i;
            }
        }
        else if (a > b)
        {
            for (int i = b; i <= a; ++i)
            {
                sumBetween += i;
            }
        }

        return sumBetween;
    }
    static bool TrySumIfOdd(int a, int b, out int sum)
    {
        sum = SumBetweenNumbers(a, b);
        return sum % 2 != 0;
    }
    // Extra task
static string Repeat(string x, int n) 
{
    string y = "";
    for (int i = 0; i < n; i++)
    {
        y += x;
    }
    return y;
}
/* Recursion option (but with FOR it's better and faster)
static string Repeat(string x, int n)
{
    if(n == 1)
    {
        return x;
    }
    return x += Repeat(x, n - 1);
}
*/
    private static void Main(string[] args)
    {

        // Fibonacci number
        const int N = 1;
        var result = 0;
        int f1 = 1, f2 = 1;
        for (int i = f1; i < N || i == 1; ++i)
        {
            result += f1;
            f1 = f2;
            f2 = result;
        }
        Console.WriteLine($"{N}-th Fibonacci number is {result}");
        Console.WriteLine(MaxValueAmong(12, 25, 41));
        Console.WriteLine(MaxValueAmong(12, 25, 1, 85));
        Console.WriteLine(MinValueAmong(14, 25, 36));
        Console.WriteLine(TrySumIfOdd(5, 8, out int sum));
        Console.WriteLine(TrySumIfOdd(10, 12, out sum));
        string firstLineOfTheChorus = Repeat("Bang ", 2);
        Console.WriteLine($"{firstLineOfTheChorus.Substring(0, firstLineOfTheChorus.Length - 1)}, he shot me down");
        Console.WriteLine($"{firstLineOfTheChorus.Substring(0, firstLineOfTheChorus.Length - 1)}, I hit the ground");
        
    }
}