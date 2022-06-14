internal class Program
{
    static int MaxValueAmong(int a, int b) 
    {
        return a >= b ? a : b;
    }
    static int MaxValueAmong(int a, int b, int c) 
    {
        return MaxValueAmong(MaxValueAmong(a, b), c);
    }
    static int MaxValueAmong(int a, int b, int c, int d) 
    {
        return MaxValueAmong(MaxValueAmong(a, b), MaxValueAmong(c, d));
    }
    static int MinValueAmong(int a, int b) 
    {
        return a <= b ? a : b;
    }
    static int MinValueAmong(int a, int b, int c) 
    {
        return MinValueAmong(MinValueAmong(a, b), c);
    }
    static int MinValueAmong(int a, int b, int c, int d) 
    {
        return MinValueAmong(MinValueAmong(a, b), MinValueAmong(c, d));
    }
    static bool TrySumIfOdd(int a, int b, out int sum) 
    {
        sum = CheckHowToCountSum(a, b);
        return sum % 2 != 0;
    }
    static int CheckHowToCountSum(int fromNumber, int toNumber) 
    {        
        if (fromNumber <= toNumber)
        {
            return CountSumBetweenIntegers(fromNumber, toNumber);
        }
        return CountSumBetweenIntegers(toNumber, fromNumber);
    }
    static int CountSumBetweenIntegers(int fromNumber, int toNumber)
    {
        int sum = 0;

        for (int i = fromNumber; i <= toNumber; ++i)
        {
            sum += i;
        }

        return sum;
    }
    static string Repeat(string x, int n) 
    {
        string stringToReturn = "";
        for (int i = 0; i < n; i++)
        {
            stringToReturn += x;
        }
        return stringToReturn;
    }

    private static void Main(string[] args)
    {
        // Max Values
        System.Console.WriteLine(MaxValueAmong(1, 2));
        System.Console.WriteLine(MaxValueAmong(1, 2, 3));
        System.Console.WriteLine(MaxValueAmong(1, 2, 3, 4));

        // Min Values
        System.Console.WriteLine(MinValueAmong(4, 3));
        System.Console.WriteLine(MinValueAmong(4, 3, 2));
        System.Console.WriteLine(MinValueAmong(4, 3, 2, 1));

        // Try Sum If Odd
        bool isOdd = TrySumIfOdd(10, 15, out int sum);
        System.Console.WriteLine($"{sum} % 2 != 0 is {isOdd}");

        //Extra
        System.Console.WriteLine(Repeat("Oo", 5));
    }
}