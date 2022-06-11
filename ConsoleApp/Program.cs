internal class Program
{
      static void HelloWorld()
        {
            Console.WriteLine("Hello, world");
        }

        static void HelloToSOmebody(string somebody)
        {
            Console.WriteLine($"hello, {somebody}");
        }

        static int Square(int x)
        {
            return x * x;
        }

        static void add3(int initial)
        {
            initial += 3;
        }
        static void add5(ref int initial)
        {
            initial += 3;
        }

        static bool tryParseInt(string str, out int result) => int.TryParse(str, out result);
        static bool TryDivideBy3(int number, out int result)
        {
            if (number % 3 == 0)
            {
                result = number / 3;
                return true;
            }
            result = 0;
            return false;
        }
        static int SumOfTwo(int a = 1, int b = 2) => a + b;

        static double Multiply() => 42;
        static double Multiply(double a) => a * 42;
        static double Multiply(double a, double b, double c) => a * b * c;
        static  int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return -1;
            }

            int result = 1, prev = 1, counter = n - 1;

            while (--counter > 0)
                {
                var temp = result;
                result += prev;
                prev = temp;
                }
            return result;
        }
    static long FibonacciRecursive (long n)
    {
        if (n <= 0) return -1;
        if (n == 1 || n == 2)
        {
            System.Console.WriteLine($"F({n}) = 1");
            return 1;
        }
        System.Console.WriteLine($"Count F({n}) = F({n - 1}) + F({n - 2})");
        var result = FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        System.Console.WriteLine($"Result F({n}) = {result}");

        return result;
    }
    static bool TrySumIfOdd (int x, int y, out int sum)
    private static void Main(string[] args)
    {
      
        HelloWorld();

        HelloToSOmebody("Yurii");
        HelloToSOmebody("Class");

        var square3 = Square(3);
        Console.WriteLine(square3);

        //the same as above
        Console.WriteLine(Square(3));

        var initial = 5;
        Console.WriteLine("ADD 3");
        add3(initial);
        Console.WriteLine(initial);

        Console.WriteLine("ADD 5");
        add5(ref initial);
        Console.WriteLine(initial);

        //int success = tryParseInt("42", out var result);
        //System.Console.WriteLine($"Success: {success}. Result: {result}");

        //success = TryDivideBy3(6, out initial);
        //System.Console.WriteLine($"Success: {success}. Result: {initial}");

        //success = TryDivideBy3(7, out initial);
        //System.Console.WriteLine($"Success: {success}. Result: {initial}");

        Console.WriteLine(SumOfTwo(5, 6));
        Console.WriteLine(SumOfTwo());
        Console.WriteLine(SumOfTwo(5));
        Console.WriteLine(SumOfTwo(b: 6));

        System.Console.WriteLine(Multiply());
        System.Console.WriteLine(Multiply(5));
        System.Console.WriteLine(Multiply(5, 6, 2));

        System.Console.WriteLine("Fibonacci");
        System.Console.WriteLine(Fibonacci(1));
        System.Console.WriteLine(Fibonacci(8));

        System.Console.WriteLine("FibonacciRecursive");
        System.Console.WriteLine("FOR 1");
        System.Console.WriteLine(FibonacciRecursive(1));
        System.Console.WriteLine("FOR 8");
        System.Console.WriteLine(FibonacciRecursive(8));
    }
}