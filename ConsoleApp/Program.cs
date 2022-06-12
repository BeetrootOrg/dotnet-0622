internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Enter first number:");
        var num1 = Console.ReadLine();
        System.Console.Write("Enter second number:");
        var num2 = Console.ReadLine();
        System.Console.Write("Enter 3th number:");
        var num3 = Console.ReadLine();
        System.Console.Write("Enter 4th number:");
        var num4 = Console.ReadLine();

        if (int.TryParse(num1, out int pNumber1)
        && int.TryParse(num2, out int pNumber2)
        && int.TryParse(num3, out int pNumber3)
        && int.TryParse(num4, out int pNumber4))
        {
            System.Console.WriteLine($"Min between 2 number: {GetMinNumb(pNumber1, pNumber2)}");
            System.Console.WriteLine($"Max between 2 number: {GetMaxNumb(pNumber1, pNumber2)}");

            System.Console.WriteLine($"Min between 3 number: {GetMinNumb(pNumber1, pNumber2, pNumber3)}");
            System.Console.WriteLine($"Max between 3 number: {GetMaxNumb(pNumber1, pNumber2, pNumber3)}");

            System.Console.WriteLine($"Min between 4 number: {GetMinNumb(pNumber1, pNumber2, pNumber3, pNumber4)}");
            System.Console.WriteLine($"Max between 4 number: {GetMaxNumb(pNumber1, pNumber2, pNumber3, pNumber4)}");


            var success = TrySumIfOdd(pNumber1, pNumber2, out int sum);
            System.Console.WriteLine($"Check for odd numbers: {!success} sum numbers: {sum}");

            System.Console.WriteLine("Extra");

            System.Console.Write("Enter text:");
            var text = Console.ReadLine();
            System.Console.Write("Enter number of repetitions of the text:");
            var count = Convert.ToInt32(Console.ReadLine());
           System.Console.Write(Repeat(text, count)); 
        }
        else
        {
            System.Console.WriteLine("Error you entered an incorrect number, please try again!");
            Console.ReadKey();
        }

    }

    static int GetMinNumb(int num1, int num2) //2
    {
        if (num1 < num2)
        {
            return num1;
        }
        return num2;
    }

    static int GetMinNumb(int num1, int num2, int num3) //3
    {
        if (num1 < num2 && num1 < num3)
        {
            return num1;
        }
        if (num2 < num1 && num2 < num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }

    static int GetMinNumb(int num1, int num2, int num3, int num4) //4
    {
        if (num1 < num2 && num1 < num3 && num1 < num4)
        {
            return num1;
        }
        else if (num2 < num1 && num2 < num3 && num2 < num4)
        {
            return num2;
        }
        else if (num3 < num1 && num3 < num2 && num3 < num4)
        {
            return num3;
        }
        else
        {
            return num4;
        }

    }

    static int GetMaxNumb(int num1, int num2) //2
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    static int GetMaxNumb(int num1, int num2, int num3) //3
    {
        if (num1 > num2 && num1 > num3)
        {
            return num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }

    static int GetMaxNumb(int num1, int num2, int num3, int num4) //4
    {
        if (num1 > num2 && num1 > num3 && num1 > num4)
        {
            return num1;
        }
        else if (num2 > num1 && num2 > num3 && num2 > num4)
        {
            return num2;
        }
        else if (num3 > num1 && num3 > num2 && num3 > num4)
        {
            return num3;
        }
        else
        {
            return num4;
        }
    }


    static bool TrySumIfOdd(int x, int y, out int sum)
    {
        sum = 0;
        int num1 = Math.Min(x, y);
        int num2 = Math.Max(x, y);
        for (int i = num1; i <= num2; ++i)
        {
            sum += i;
        }
        return sum % 2 == 0;
    }

    static string Repeat(string text, int count)
    {
        if (count <= 0) return "";
        return text + "\n" + Repeat(text, count - 1);
    }

}