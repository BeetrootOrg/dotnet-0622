class Program 
{
     int GetMaxValue(int a, int b, int c)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c}");
        int maxValue;
        if (a >= b && a >= c)
        {
            maxValue = a;
        }
        else maxValue = (b >= c) ? b : c;

        return maxValue;
    }

    int GetMinValue(int a, int b, int c)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c}");
        int minValue;
        if (a <= b && a <= c)
        {
            minValue = a;
        }
        else minValue = (b <= c) ? b : c;

        return minValue;
    }

    int GetMaxValue(int a, int b, int c, int d)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c} d={d}");
        int maxValue;
        if (a >= b && a >= c && a >= d)
        {
            maxValue = a;
        }
        else if (d >= b && d >= c) 
        {
            maxValue = d;
        } else

        maxValue = (b >= c) ? b : c;

        return maxValue;
    }

    int GetMinValue(int a, int b, int c, int d)
    {
        Console.WriteLine ($"Method was called and it got follow parameters: a={a} b={b} c={c} d={d}");
        int minValue;
        if (a <= b && a <= c && a <= d)
        {
            minValue = a;
        }
        else if (d <= b && d <= c)
        {
            minValue = d;
        }   
        else minValue = (b <= c) ? b : c;

        return minValue;
    }


    // TrySumIfOdd

    bool TrySumIfOdd(int x, int y, out int sum)
    {
        sum = Math.Min(x , y);
        while (x != y)
        {
            sum += (x > y) ? ++y : ++x;
        }
        //Console.WriteLine($"The sum is {sum}");
        if (sum % 2 != 0) 
        {   
            return true;
        } 
        else
        {
            return false;
        } 
        
    }

    bool Get2Values (out int x, out int y)
    {
        x = 0;
        y = 0;
        
        // Entering x
        Console.WriteLine("Hello, let's do some loops, please enter whole number x:");

        var console = Console.ReadLine();

        if (int.TryParse(console, out x))
        {
        // Console.WriteLine("x="+ x);
        } 
        else 
        { 
            Console.WriteLine("x is not an integer number, run again and put right value");
            return false;
        }   

        // Entering y
        Console.WriteLine("Now enter whole number y:");

        console = Console.ReadLine();

        if (int.TryParse(console, out y))
        {
            //Console.WriteLine("y="+ y);
        } 
        else
        { 
            Console.WriteLine("y is not an integer number, run again and put right value");
            return false;
        }
    return true;
    }

    string Repeat(string x, int n)
        {   
            string result = $"Hello, gonna do Repeat method and show you \"{x}\" {n} times \n";
            for (int i = 0; i < n; i++)
            {
                result += x+"\n";
            }
            return result;
        }



        static void Main()
        {   
            Program myMethod = new Program();

            int result;
            result = myMethod.GetMaxValue(40, 51, 40);
            Console.WriteLine("Maximum value is: " + result);
            result = myMethod.GetMinValue(40, 51, 3);
            Console.WriteLine("Minimum value is: " + result);

            //Let's overload
            Console.WriteLine($"Overloaded results:");
            result = myMethod.GetMaxValue(40, 51, c: 40, 55);
            Console.WriteLine("Maximum value is: " + result);
            result = myMethod.GetMinValue(40, 51, 3, -3);
            Console.WriteLine("Minimum value is: " + result);

            int x;
            int y;
            bool isInputOk;
            isInputOk = (myMethod.Get2Values(out x,out y));
            Console.WriteLine($"x={x}, y={y}");

            int sum;
            if (isInputOk) Console.WriteLine($"The TrySumIsOdd is: {myMethod.TrySumIfOdd(x , y, out sum)} because the sum is {sum}");

            Console.WriteLine(myMethod.Repeat("string", 3));
            Console.WriteLine(myMethod.Repeat("Some other text", 5));

        }

}