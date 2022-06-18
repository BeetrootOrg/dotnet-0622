internal class Program
{
    static int MaxValue(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int MinValue(int a, int b)
    {
        return (a > b) ? b : a;
    }

    static int MaxValue(int a, int b, int c)
    {
        int MaxVal2 = MaxValue(a, b);
        return MaxValue(MaxVal2, c);
    }

    static int MinValue(int a, int b, int c)
    {
        int MinVal2 = MinValue(a, b);
        return MinValue(MinVal2, c);
    }

    static int MaxValue(int a, int b, int c, int d)
    {
        int MaxVal3 = MaxValue(a, b, c);
        return MaxValue(MaxVal3, d);
    }

    static int MinValue(int a, int b, int c, int d)
    {
        int MinVal3 = MinValue(a, b, c);
        return MinValue(MinVal3, d);
    }
    static public void Main(string[] args)
    {
        System.Console.WriteLine("---MAX Values---");
        System.Console.WriteLine(MaxValue(22, 33, 99, 777));
        System.Console.WriteLine(MaxValue(0, 444, 333));
        System.Console.WriteLine(MaxValue(-10, 0));
        System.Console.WriteLine("---MIN Values---");
        System.Console.WriteLine(MinValue(4, 5, 0, 6));
        System.Console.WriteLine(MinValue(-1, 1, 0));
        System.Console.WriteLine(MinValue(1000, 7777));

        static bool TrySumIfOdd(int a, int b, out int sum)
        {
            sum = 0;
            int first = Math.Min(a, b);
            int second = Math.Max(a, b);
            for (int i = first; i <= second; ++i)
            {
                sum += i;
            }
            return sum % 2 == 0;
        }
        bool result = TrySumIfOdd(2, 9, out var sum);
        System.Console.WriteLine("---Try sum if odd---");
        System.Console.WriteLine($"{result}, {sum}\n");

        //extra
        static string Repeat(string x, int n)
        {
            if (n <= 0) return "";
            return x + "\n" + Repeat(x, n - 1);
        }

        string text = "anything";
        var n = 3;
        System.Console.WriteLine("---Repeat---");
        System.Console.WriteLine($"What will we repeat {n} times? \n");
        System.Console.WriteLine(Repeat(text, n));
    }

}