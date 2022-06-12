internal class Program
{
    // 1st part of the task
    static int MaxValueAmong(int a, int b) => Math.Max(a, b);
    static int MaxValueAmong(int a, int b, int c) => Math.Max(Math.Max(a, b), c);
    static int MaxValueAmong(int a, int b, int c, int d) => Math.Max(Math.Max(a, b), Math.Max(c, d));
    // second part of the task
    static int MinValueAmong(int a, int b) => Math.Min(a, b);
    static int MinValueAmong(int a, int b, int c) => Math.Min(Math.Min(a, b), c);
    static int MinValueAmong(int a, int b, int c, int d) => Math.Min(Math.Min(a, b), Math.Min(c, d));
    //third part of the task

    static int SumBetweenNumbers(int a, int b)
    {
        int sumBetween = 0;
        if (a < b)
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
        else
        {
            sumBetween = a;
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
        Console.WriteLine(MaxValueAmong(56, 76));
        Console.WriteLine(MaxValueAmong(12, 853, 852));
        Console.WriteLine(MaxValueAmong(12, 25, 1, 85));
        Console.WriteLine(TrySumIfOdd(5, 8, out sum));
        Console.WriteLine(TrySumIfOdd(10, 12, out sum));
    }
}