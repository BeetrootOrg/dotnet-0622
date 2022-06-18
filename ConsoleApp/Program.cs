internal class Program

{   static int MaxValue (int a, int b)
    {
        return a >= b ? a : b;
    }
    static int MaxValue (int a, int b, int c)
    {
        int max2values = MaxValue ( a, b );
        return MaxValue  (max2values, c);

    }
    static int MaxValue (int a, int b, int c, int d)
    {
        int max3values = MaxValue (a, b, c);
        return MaxValue (max3values, d );
    }
    static int MinValue (int a, int b)

    {
        return a <= b ? a : b;
    }
    static int MinValue (int a, int b, int c)
    {
        int min2values = MinValue ( a, b );
        return MinValue  (min2values, c);

    }
    static int MinValue (int a, int b, int c, int d)
    {
        int min3values = MinValue (a, b, c);
        return MinValue (min3values, d );
    }
    static bool TrySumIfOdd (int a, int b, out int sum)
    {
         int start;
         int end;
         if (a>=b)
         { 
            start = b;
            end = a;
         }
         else
         {
            start = a;
            end = b;
         }
         sum = 0;
         for (int i = start; i<= end; i++) 
         {
            sum += i;
         }

         return sum % 2 == 0 ? false : true;

    }
     static public void Main (string[] args)
   {
    System.Console.WriteLine(MaxValue (1, 2, 3, 4));
    System.Console.WriteLine(MaxValue (99, 100, 34));
    System.Console.WriteLine(MaxValue (-15, 0));
    System.Console.WriteLine(MinValue (1, 2, 3, 4));
    System.Console.WriteLine(MinValue (-1, 1, 0));
    System.Console.WriteLine(MinValue (9999, 10000));
    int sum = 0;
    bool result = TrySumIfOdd (1, 98, out sum);
    System.Console.WriteLine($"Is sum odd? It is {result}");
   }
}

