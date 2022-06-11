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
            System.Console.WriteLine(GetMinNumb(pNumber1, pNumber2));
            System.Console.WriteLine(GetMaxNumb(pNumber1, pNumber2));
        }
        else
        {
            System.Console.WriteLine("error");
        }

        static int GetMinNumb(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static int GetMaxNumb(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }


        static bool TrySumIfOdd(int x, int y, out int sum)
        {
            sum = 0;
            for (int i = x; i <= y; ++i)
            {
                sum += i;
            }
            System.Console.WriteLine($"Sum from {x} to {y} = {sum}");

            return sum % 2 == 0;
        }

    }
}