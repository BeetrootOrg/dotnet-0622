class Program
{
    static int MaxValue(int firstParam, int secondParam)
    {       
        if (firstParam > secondParam) return firstParam;
        if (firstParam < secondParam) return secondParam;
        else return firstParam;        
    }
    static int MinValue(int firstParam, int secondParam)
    {
        if (firstParam < secondParam) return firstParam;
        if (firstParam > secondParam) return secondParam;
        else return firstParam;
    }
    
    static int MaxValue(int firstParam, int secondParam, int thirdParam)
    {
        int maxValue;
        return maxValue = MaxValue(MaxValue(firstParam, secondParam), thirdParam);
    }
    static int MaxValue(int firstParam, int secondParam, int thirdParam, int fourthParam)
    {
        int maxValue;
        return maxValue = MaxValue(MaxValue(MaxValue(firstParam, secondParam), thirdParam), fourthParam);
    }
    static int MinValue(int firstParam, int secondParam, int thirdParam)
    {
        int minValue;
        return minValue = MinValue(MinValue(firstParam, secondParam), thirdParam);
    }
    static int MinValue(int firstParam, int secondParam, int thirdParam, int fourthParam)
    {
        int minValue;
        return minValue = MinValue(MinValue(MinValue(firstParam, secondParam), thirdParam), fourthParam);
    }
    static bool TrySumIfOdd(int firstParam, int secondParam, out int sumResult)
    {
        if ((firstParam + secondParam) % 2 != 0)
        {
            sumResult = firstParam + secondParam;
            return true;
        }
        else
        {
            sumResult = firstParam + secondParam;
            return false;
        }
    }

    static string Repeat(string str, int n)
    { 
        int i = 0;
        if (i >= n)
        {
            return "";
        } 
        i++;
        return str + Repeat (str, n-1);

    }

    static void Main(string[] args)
    {
   
        int maxValue = MaxValue(6, 4);
        Console.WriteLine($"Max value fo two parameters: {maxValue}");
                
        int minValue = MinValue(6, 4);
        Console.WriteLine($"Min value fo two parameters: {minValue}");
                
        int maxValue1 = MaxValue(1, 2, 3);
        Console.WriteLine($"Max value fo three parameters: {maxValue1}");

        int minValue1 = MinValue(6, 4, 1);
        Console.WriteLine($"Min value fo three parameters: {minValue1}");

        int maxValue2 = MaxValue(1, 5, 3, 4);
        Console.WriteLine($"Max value fo four parameters: {maxValue2}");

        int minValue2 = MinValue(6, 4, 8, 7);
        Console.WriteLine($"Min value fo four parameters: {minValue2}");

        int sumResult;
        TrySumIfOdd(2, 3, out sumResult);
        Console.WriteLine($"Sum of 2 numbers : {sumResult}");

        //recursion        
        Console.WriteLine(Repeat("bla", 3));
        
    }
}