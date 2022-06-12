internal class Program
{
    static int MaxBetween (int a, int b)
    {
        if (a>b)
            return a;
        else 
            return b;
    }

    static int MaxBetween (int a, int b, int c)
    {
        int[] numbers = new int[] {a, b, c};
        for (int i=0; i<numbers.Length-1; i++)
            for (int j=0; j<numbers.Length-1; j++)
            {
                if (numbers[j]<numbers[j+1])
                {
                    int buffer = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = buffer;
                }
            }
        return numbers[0];
    }

    static int MaxBetween (int a, int b, int c, int d)
    {
        int[] numbers = new int[] {a, b, c, d};
        for (int i=0; i<numbers.Length-1; i++)
            for (int j=0; j<numbers.Length-1; j++)
            {
                if (numbers[j]<numbers[j+1])
                {
                    int buffer = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = buffer;
                }
            }
        return numbers[0];
    }

    static int MinBetween (int a, int b)
    {
        if (a<b)
            return a;
        else 
            return b;
    }

    static int MinBetween (int a, int b, int c)
    {
        int[] numbers = new int[] {a, b, c};
        for (int i=0; i<numbers.Length-1; i++)
            for (int j=0; j<numbers.Length-1; j++)
            {
                if (numbers[j]>numbers[j+1])
                {
                    int buffer = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = buffer;
                }
            }
        return numbers[0];
    }

    static int MinBetween (int a, int b, int c, int d)
    {
        int[] numbers = new int[] {a, b, c, d};
        for (int i=0; i<numbers.Length-1; i++)
            for (int j=0; j<numbers.Length-1; j++)
            {
                if (numbers[j]>numbers[j+1])
                {
                    int buffer = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = buffer;
                }
            }
        return numbers[0];
    }

    static bool TrySumIfOdd (int a, int b, out int sum)
    {
        bool result;
        if (b>a) {
            sum = (Math.Abs(b-a+1)*(b+a))/2;
            result = (sum % 2 == 0) ? false : true;
            return result;
        } else {
            sum = (Math.Abs(a-b+1)*(a+b))/2;
            result = (sum % 2 == 0) ? false : true;
            return result;
        }
    }

    static string Repeat (string str, int n)
    {
        string result = "";        
        if ( n <= 0 ) return "";
        result = str + Repeat(str, n-1);
        return result;
    }
    private static void Main(string[] args)
    {        
        int sum;
        Console.WriteLine($"Result: {TrySumIfOdd(1, 5, out sum)}; Sum: {sum}");
        Console.WriteLine($"Result: {TrySumIfOdd(1, 7, out sum)}; Sum: {sum}");
        Console.WriteLine($"Result: {TrySumIfOdd(12, 44, out sum)}; Sum: {sum}");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine("MAX");
        Console.WriteLine(MaxBetween(3,25,10,100));
        Console.WriteLine(MaxBetween(4,25,123,5));
        Console.WriteLine(MaxBetween(316,25,64));
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine("MIN");
        Console.WriteLine(MinBetween(3,25,10,1));
        Console.WriteLine(MinBetween(123,25,4,321));
        Console.WriteLine(MinBetween(25,32,64));
        Console.WriteLine("---------------------------------------------");
        
        Console.WriteLine("Repeat");
        Console.WriteLine(Repeat("Sanya", 5));
        Console.WriteLine(Repeat("Dima", 10));
        Console.WriteLine(Repeat("Pasha", 0));      
        Console.WriteLine(Repeat("Vasya", -1));    
        Console.WriteLine("---------------------------------------------");
        
    }
}