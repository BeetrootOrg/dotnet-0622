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
        if (sum % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Extra task

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

        int sum = 0;
        Console.WriteLine(MaxValueAmong(12, 25, 41));
        Console.WriteLine(MaxValueAmong(12, 25, 1, 85));
        Console.WriteLine(MinValueAmong(14, 25, 36));
        Console.WriteLine(TrySumIfOdd(5, 8, out sum));
        Console.WriteLine(TrySumIfOdd(10, 12, out sum));
        
    }
}