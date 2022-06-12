internal class Program 
{
    static int GetMaxValue(int a, int b)
    {
        return Math.Max(a, b);
    }

        static int GetMinValue(int a, int b)
    {
        return Math.Min(a, b);
    }

    static int GetMaxValue(int a, int b, int c)
    {
        int maxValue;
        maxValue = Math.Max (a, b);
        maxValue = Math.Max (maxValue, c);

        return maxValue;
    }

    static int GetMinValue(int a, int b, int c)
    {
        int minValue;
        minValue = Math.Min (a, b);
        minValue = Math.Min (minValue, c);

        return minValue;
    }

    static int GetMaxValue(int a, int b, int c, int d)
    {
        int maxValue;
        maxValue = Math.Max (a, b);
        maxValue = Math.Max (maxValue, c);
        maxValue = Math.Max (maxValue, d);

        return maxValue;
    }

   static int GetMinValue(int a, int b, int c, int d)
    {
        int minValue;
        minValue = Math.Min (a, b);
        minValue = Math.Min (minValue, c);
        minValue = Math.Min (minValue, d);

        return minValue;
    }
    // TrySumIfOdd

    static bool TrySumIfOdd(int x, int y, out int sum)
    {
        sum = Math.Min(x , y);

        while (x != y)
        {
            sum += (x > y) ? ++y : ++x;
        }

        return sum % 2 != 0;
        
    }

    static bool Get2Values (out int x, out int y)
    {
        x = 0;
        y = 0;
        
        // Entering x
        Console.WriteLine("Hello, let's do some loops, please enter whole number x:");

        var console = Console.ReadLine();

        if (!int.TryParse(console, out x))
        { 
            Console.WriteLine("x is not an integer number, run again and put right value");
            return false;
        }   

        // Entering y
        Console.WriteLine("Now enter whole number y:");

        console = Console.ReadLine();

        if (!int.TryParse(console, out y))
        { 
            Console.WriteLine("y is not an integer number, run again and put right value");
            return false;
        }
    return true;
    }

    static string Repeat(string x, int n)
        {   
            if (n <= 0) return "";    
            return x + "\n"+ Repeat(x, n-1);
        }



        static void Main(string[] args)
        {   
            int result;
            result = GetMaxValue(49, -10);
            Console.WriteLine("Maximum value is: " + result);
            result = GetMinValue(42, 59);
            Console.WriteLine("Minimum value is: " + result);

            //Let's overload
            Console.WriteLine($"Overloaded results:");

            result = GetMaxValue(40, 51, 40);
            Console.WriteLine("Maximum value is: " + result);
            result = GetMinValue(40, 51, 3);
            Console.WriteLine("Minimum value is: " + result);
            result = GetMaxValue(40, 51, c: 40, 55);
            Console.WriteLine("Maximum value is: " + result);
            result = GetMinValue(40, 51, 3, -3);
            Console.WriteLine("Minimum value is: " + result);

            bool isInputOk;
            isInputOk = (Get2Values(out int x,out int y));
            Console.WriteLine($"x={x}, y={y}");

            if (isInputOk) Console.WriteLine($"The TrySumIsOdd is: {TrySumIfOdd(x , y, out int sum)} because the sum is {sum}");
            
            string someText = "Some text that we gonna repeat";
            int n = 3;
            Console.WriteLine($"Hello, gonna do Repeat method and show you \"{someText}\" {n} times \n");
            Console.WriteLine(Repeat(someText, n));
        }

}