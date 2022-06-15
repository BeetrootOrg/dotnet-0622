internal class Program
{
    static int MaxValue(int a, int b) => a > b ? a : b;
    static int MaxValue(int a, int b, int c)
    {
        int temp = MaxValue(a,b);
        return MaxValue(temp,c);
    }
    static int MaxValue(int a, int b, int c, int d)
    {
        int temp_1 = MaxValue(a,b);
        int temp_2 = MaxValue(c,d);
        return MaxValue(temp_1,temp_2);
    }


    static int MinValue(int a, int b) => a < b ? a : b;
    static int MinValue(int a, int b, int c)
    {
        int temp = a < b ? a : b;
        switch (temp < c)
        {
            case true:
                {
                    return temp;
                }
            case false:
                {
                    return c;
                }
        }
    }
    static int MinValue(int a, int b, int c, int d)
    {
        int temp_1 = MinValue(a,b);
        int temp_2 = MinValue(c, d);
        return MinValue(temp_1,temp_2);
    }

    static bool TrySumIfOdd(int x, int y, out int sum)
    {
        int biggest = x > y ? x : y;
        int smallest = x < y ? x : y;
        sum = 0;
        while (smallest + 1 < biggest)
        {
            sum += smallest + 1;
            smallest++;
        }
        return sum % 2 == 0 ? false: true;
    }

    static string Repeat(string x, int n)
    {
        if(n <= 0)
        {
            return "";
        }
        else
        {
            return x + Repeat(x, n - 1);
        }
    }


    private static void Main(string[] args)
    {
        //Random numbers
        var rand = new Random();
        int first, second, third, fourth = 0;
        first = rand.Next(0, 500);
        second = rand.Next(0, 500);
        third = rand.Next(0, 500);
        fourth = rand.Next(0, 500);
        Console.WriteLine("First number:" + first + " Second number:" + second + " Third number:" + third + " Fourth number:" + fourth);

        //MAXVALUE
        //call MaxValue method with 2 arguments
        Console.WriteLine($"call MaxValue method with 2 arguments {first}, {second}");
        Console.WriteLine(MaxValue(first, second));
        Console.WriteLine();

        //call MaxValue method with 3 arguments
        Console.WriteLine($"call MaxValue method with 3 arguments {first}, {second}, {third}");
        Console.WriteLine(MaxValue(first, second, third));
        Console.WriteLine();

        //call MaxValue method with 4 arguments
        Console.WriteLine($"call MaxValue method with 4 arguments {first}, {second}, {third}, {fourth}");
        Console.WriteLine(MaxValue(first, second, third, fourth));
        Console.WriteLine();


        //MINVALUE
        //call MinValue method with 2 arguments
        Console.WriteLine($"MinValue method with 2 arguments {first}, {second}");
        Console.WriteLine(MinValue(first, second));
        Console.WriteLine();

        //call MinValue method with 3 arguments
        Console.WriteLine($"MinValue method with 3 arguments {first}, {second}, {third}");
        Console.WriteLine(MinValue(first, second, third));
        Console.WriteLine();

        //call MinValue method with 4 arguments
        Console.WriteLine($"MinValue method with 4 arguments {first}, {second}, {third}, {fourth}");
        Console.WriteLine(MinValue(first, second, third, fourth));
        Console.WriteLine();


        //TrySumIfOdd method
        Console.WriteLine("TrySumIfOdd method:");
        int sum = 0;
        bool result = TrySumIfOdd(4,9,out sum);
        Console.WriteLine(result);
        Console.WriteLine(sum);
        Console.WriteLine();


        //EXTRA
        Console.WriteLine("Extra task:");
        string resultString = Repeat("abba", rand.Next(1,7)); 
        Console.WriteLine(resultString);
    }
}