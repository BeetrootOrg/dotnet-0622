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
            System.Console.WriteLine($"Min number: {GetMinNumb(pNumber1, pNumber2)}");
            System.Console.WriteLine($"Max number: {GetMaxNumb(pNumber1, pNumber2)}");
            var success = TrySumIfOdd(pNumber1, pNumber2, out int sum);
            System.Console.WriteLine($"Check for odd numbers: {!success} sum numbers: {sum}");
        }
        else
        {
            System.Console.WriteLine("Error you entered an incorrect number, please try again!");
            Console.ReadKey();
        }

        static int GetMinNumb(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }

        static int GetMaxNumb(int x, int y)
        {
            if (x < y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }


        static bool TrySumIfOdd(int x, int y, out int sum)
        {
            sum = 0;
            int num1 = Math.Min(x, y);
            int num2 = Math.Max(x, y);
            for (int i = x; i <= y; ++i)
            {
                sum += i;
            }
            return sum % 2 == 0;
        }

    }
}