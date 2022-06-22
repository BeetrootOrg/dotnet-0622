using System;

internal class Program
{
    static int Max(int a, int b) => a < b ? b : a;
    static int Max(int a, int b, int c) => Max(Max(a, b), c);
    static int Max(int a, int b, int c, int d) => Max(Max(a, b, c), d);

    static bool TrySumIfOdd(int a, int b, out int sum)
    {
        sum = a + b;
        return sum % 2 == 1;
    }

    static string Repeat(string str, int num)
    {
        if (str == null) return null;
        if (str == string.Empty) return string.Empty;
        if (num < 0) return null;
        if (num == 0) return string.Empty;
        return str + Repeat(str, num - 1);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(Repeat("str", 3));
        Console.WriteLine(Repeat("str", 1));
        Console.WriteLine(Repeat("str", 0));
        Console.WriteLine(Repeat("str", -1));
    }
}