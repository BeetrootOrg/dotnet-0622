internal class Program
{
            static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void HelloToSomebody(string somebody)
        {
            Console.WriteLine($"Hello {somebody}");
        }

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
            initial += 5;
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

        static int Sum(int a = 1, int b = 0) => a + b;
        static double Multiply() => 42;
        static double Multiply(double a) => a * 42;
        static double Multiply(double a, double b, double c) => a * b * c;
        static int Multiply(int a, int b, int c)=> a * b * c;

        static int Fibonacci(int n)
        {
              if(n<=0)
              {
                return -1;
              }
            var result = 0;

            var prev = 1;
            result = 1;
            var counter = n - 1;

            while (--counter > 0)
            {
                var temp = result;
                result += prev;
                prev = temp;
            }
            Console.WriteLine($"{n}-th Fibonacci number is {result}");
            return result;
        }
                
     
     static int FibbonachiRecursive(int n)
     {
        if(n <= 0) return -1;
        if (n == 1 || n == 2 ) return 1;
        return FibbonachiRecursive(n-1) + FibbonachiRecursive(n-2);
     }
    private static void Main(string[] args)
    {
        

        HelloWorld();
        HelloToSomebody("Ivan");

        var square3 = Square(3);
        Console.WriteLine(square3);
        Console.WriteLine(Square(3));

        var initial = 5;
        Add3(initial);
        Console.WriteLine(initial);

        Add5(ref initial);
        Console.WriteLine(initial);

        var success = int.TryParse("42", out var result);
        Console.WriteLine($"Success: {success}. Result:{result}");

        success = TryDivideBy3(6, out initial);
        Console.WriteLine($"Success: {success}. Result:{initial}");
        success = TryDivideBy3(7, out initial);
        Console.WriteLine($"Success: {success}. Result:{initial}");

        success = TryDivideBy4(8, out initial);
        Console.WriteLine($"Success: {success}. Result:{initial}");
        success = TryDivideBy4(9, out initial);
        Console.WriteLine($"Success: {success}. Result:{initial}");

        TryRef(ref initial);
        initial = 30;
        TryRef(ref initial);

        Console.WriteLine(Sum(5 + 6));
        Console.WriteLine(Sum());
        Console.WriteLine(Sum(5));
        Console.WriteLine(Sum(b: 6));

        System.Console.WriteLine(Multiply());
        System.Console.WriteLine(Multiply(5));
        System.Console.WriteLine(Multiply(5, 6, 2));
        System.Console.WriteLine(Multiply(5.5, 6.5, 7.5));

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
        System.Console.WriteLine(FibbonachiRecursive(1));

        System.Console.WriteLine("FOR 2");
        System.Console.WriteLine(FibbonachiRecursive(2));

        System.Console.WriteLine("FOR 3");
        System.Console.WriteLine(FibbonachiRecursive(3));

        System.Console.WriteLine("FOR 8");
        System.Console.WriteLine(FibbonachiRecursive(8));

        System.Console.WriteLine(FibbonachiRecursive(0));
        System.Console.WriteLine(FibbonachiRecursive(-2));
    }
}