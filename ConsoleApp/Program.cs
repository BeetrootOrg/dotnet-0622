internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Enter first number:");
        var num1 = Console.ReadLine();
        System.Console.Write("Enter second number:");
        var num2 = Console.ReadLine();
        if (int.TryParse(num1, out int pNumber1) && int.TryParse(num2, out int pNumber2))
        {
            GetMaxMin(pNumber1,pNumber2);
        }
        else 
        {
            System.Console.WriteLine("error");
        }



    }

    static void GetMaxMin (int num1, int num2)
    {
        if(num1 > num2)
        {
            System.Console.WriteLine($"First number {num1} is greater than second number: {num2}");
        }
        else
        {
            System.Console.WriteLine($"Second number {num2} is greater than first number: {num1}");
        }
    }

        static bool TrySumIfOdd (int x, int y,  out int sum)
        {
            sum;
        }

    
}