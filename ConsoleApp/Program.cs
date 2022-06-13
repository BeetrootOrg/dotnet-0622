internal class Program
{
    static int ProvideMaxValue (int number1, int number2) 
    {
        if (number1 >= number2)
        {
            return number1;
        }
        return number2;
    }
    static int ProvideMaxValue (int number1, int number2, int number3, int number4)
    {
        if (ProvideMaxValue (number1, number2) >= ProvideMaxValue(number3, number4))
        {
            return ProvideMaxValue (number1, number2);
        }
        return ProvideMaxValue(number3, number4);
    }
    static int ProvideMinValue (int number1, int number2)
    {
        if (number1 <= number2)
        {
            return number1;
        }
        return number2;

    }
    static int ProvideMinValue (int number1, int number2, int number3, int number4)
    {
        if (ProvideMinValue(number1, number2) <= ProvideMinValue(number3, number4))
        {
            return ProvideMinValue(number1, number2);
        }
        return ProvideMinValue(number3, number4);
    }
    static bool TrySumIfOdd (int number1, int number2, out int sum)
    {
        int sum1 = number1 + number2;
        if (sum1 % 2 == 0)
        {
            sum = 0;
            return false;
        }
        else
        {
            sum = sum1;
            return true;
        }
    }
    static string Repeat (string x, int y)
    {
       if (y <= 0) return "Incorrect number of amounts";
       if (y == 1) return x;
       return x + Repeat(x, --y);
    }
    private static void Main(string[] args)
    {
        int biggerNumber = ProvideMaxValue(14, 12);
        Console.WriteLine(biggerNumber);
        int smallerNumber = ProvideMinValue(14, 12);
        Console.WriteLine(smallerNumber);
        bool result = TrySumIfOdd(7,4, out var sum);
        Console.WriteLine($"{result}, {sum}");
        int evenBiggerNumber = ProvideMaxValue(10, 12, 14, 15);
        Console.WriteLine(evenBiggerNumber);
        int evenSmallerNumber = ProvideMinValue(10, 12, 14, 15);
        Console.WriteLine(evenSmallerNumber);
        string something = Repeat("str", 10);
        Console.WriteLine(something);
    }
}