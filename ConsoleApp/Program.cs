public class Program
{
    public static int MaxValue(int firstParam, int secondParam)
    {
        int maxValue;
        return maxValue = Math.Max(firstParam, secondParam);
    }
    public static int MinValue(int firstParam, int secondParam)
    {
        int minValue;
        return minValue = Math.Min(firstParam, secondParam);
    }

    static void Main(string[] args)
    {
   
        int maxValue = MaxValue(6, 4);
        System.Console.WriteLine(maxValue);
        int minValue = MinValue(6, 4);
        System.Console.WriteLine(minValue);

    }
}