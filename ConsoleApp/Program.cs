internal class Program 
{
    static int GetMaxValue(int a, int b)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b}");
        return Math.Max(a, b);
    }

        static int GetMinValue(int a, int b)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b}");
        return Math.Min(a, b);
    }

    static int GetMaxValue(int a, int b, int c)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c}");
        return new int [] {a, b, c}.Max();
    }

    static int GetMinValue(int a, int b, int c)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c}");
        return new int [] {a, b, c}.Min();
    }

    static int GetMaxValue(int a, int b, int c, int d)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c} d={d}");
        return new int [] {a, b, c, d}.Max();
    }

   static int GetMinValue(int a, int b, int c, int d)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c} d={d}");
        return new int [] {a, b, c, d}.Min();
    }
    // TrySumIfOdd

    static bool TrySumIfOdd(int x, int y, out int sum)
    {
        sum = Math.Min(x , y);

        while (x != y)
        {
            sum += (x > y) ? ++y : ++x;
        }

        if (sum % 2 != 0) 
        {   
            return true;
        } 
        else
        {
            return false;
        } 
        
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

    static void Repeat(string x, int n)
        {   
            if (n > 0) 
            {
              Console.WriteLine($"n:{n} " + x);
              Repeat(x, n-1);  
              return;
            }
            else return;
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
            int n = 5;
            Console.WriteLine($"Hello, gonna do Repeat method and show you \"{someText}\" {n} times \n");
            Repeat(someText, n);

        }

}