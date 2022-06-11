internal class Program
{
    static void HelloWorld()
    {
        Console.WriteLine("Hello, world");
    }

    static void HelloToSomebody(string somebody) => Console.WriteLine($"Hello, {somebody}");

    static int Square(int x)
    {
        return x * x;
    }

    static void Add3(int initial)
    {
        initial += 3;
    }

    static void Add5(ref int initial)
    {
        initial += 3;
    }

    static bool TryParseInt(string str, out int result) => int.TryParse(str, out result);
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

    static bool TryDivideBy4(int number, out int result)
    {
        result = number / 4;
        return number % 4 == 0;
    }

    static void TryRef(ref int value)
    {
        if (value > 10)
        {
            value += 20;
        }
    }

    // Compilation error
    // static void TryOut(out int value)
    // {
    //     if (value > 10)
    //     {
    //         value += 20;
    //     }
    // }

    static int SumOfTwo(int a = 1, int b = 2) => a + b;

    static double Multiply() => 42;
    static double Multiply(double a) => a * 42;
    static double Multiply(double a, double b, double c) => a * b * c;
    static int Multiply(int a, int b, int c) => a * b * c;
    static int Multiply(int a, int b) => a * b;
    static int Multiply(int a) => a * 42;

    static long Fibonacci(long n)
    {
        if (n <= 0)
        {
            return -1;
        }

        long result = 1, prev = 1, counter = n - 1;

        while (--counter > 0)
        {
            var temp = result;
            result += prev;
            prev = temp;
        }

        return result;
    }

    static long FibonacciRecursive(long n)
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

    static void Main(string[] args)
    {
        HelloWorld();

        HelloToSomebody("Dima");
        HelloToSomebody("Class");

        var square3 = Square(3);
        Console.WriteLine(square3);

        // the same as above
        Console.WriteLine(Square(3));

        var initial = 5;
        Console.WriteLine("ADD 3");
        Add3(initial);
        Console.WriteLine(initial);

        Console.WriteLine("ADD 5");
        Add5(ref initial);
        Console.WriteLine(initial);

        // parsing
        var success = TryParseInt("42", out var result);
        Console.WriteLine($"Success: {success}. Result: {result}");

        success = TryDivideBy3(6, out initial);
        Console.WriteLine($"Success: {success}. Result: {initial}");

        success = TryDivideBy3(7, out initial);
        Console.WriteLine($"Success: {success}. Result: {initial}");

        success = TryDivideBy4(8, out initial);
        Console.WriteLine($"Success: {success}. Result: {initial}");

        success = TryDivideBy4(9, out initial);
        Console.WriteLine($"Success: {success}. Result: {initial}");

        TryRef(ref initial);
        Console.WriteLine(initial);
        initial = 30;
        TryRef(ref initial);
        Console.WriteLine(initial);

        // Compilation error
        // int newValue;
        // TryRef(ref newValue);

        Console.WriteLine(SumOfTwo(5, 6));
        Console.WriteLine(SumOfTwo());
        Console.WriteLine(SumOfTwo(5));
        Console.WriteLine(SumOfTwo(b: 6));

        Console.WriteLine(Multiply());
        Console.WriteLine(Multiply(5));
        Console.WriteLine(Multiply(5, 6, 2));
        Console.WriteLine(Multiply(5.5, 6, 2));

        System.Console.WriteLine("Fibonacci");
        System.Console.WriteLine(Fibonacci(1));
        System.Console.WriteLine(Fibonacci(2));
        System.Console.WriteLine(Fibonacci(3));
        System.Console.WriteLine(Fibonacci(8));
        System.Console.WriteLine(Fibonacci(0));
        System.Console.WriteLine(Fibonacci(-2));

        System.Console.WriteLine(Fibonacci(1000));

        System.Console.WriteLine("Fibonacci Reccursive");
        System.Console.WriteLine("FOR 1");
        System.Console.WriteLine(FibonacciRecursive(1));

        System.Console.WriteLine("FOR 2");
        System.Console.WriteLine(FibonacciRecursive(2));

        System.Console.WriteLine("FOR 3");
        System.Console.WriteLine(FibonacciRecursive(3));

        System.Console.WriteLine("FOR 8");
        System.Console.WriteLine(FibonacciRecursive(8));

        System.Console.WriteLine(FibonacciRecursive(0));
        System.Console.WriteLine(FibonacciRecursive(-2));

        // System.Console.WriteLine(FibonacciRecursive(1000));
    }
}