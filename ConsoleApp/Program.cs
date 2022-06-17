
// 04 - Methods
// HOMEWORK
// Not your boring middle school homework — these tasks will help you in real life! Have fun with your assignment for this topic:
//
// Define and call with different parameters next methods:
//
// 1. Method that will return max value among all the parameters
// 2. ....................... min value ........................
// 3. Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false, sum return as out parameter
// 4. Overload first two methods with 3 and 4 parameters
// 
// Extra:
// Define and call with different parameters next methods:
//
// 1. Method Repeat that will accept string X and number N and return X repeated N times (e.g. Repeat(‘str’, 3) returns ‘strstrstr’ = ‘str’ three times)

internal class Program
{
    static double Define_Max(int num, long key)
    {
        double max = 0;
        max = num;
        if (max < key)
        {
            max = key;
        }
        return max;
    }

    static double Define_Max(int num, long key, float cord)
    {
        double max = 0;
        max = num;
        if (max < key)
        {
            max = key;
        }
        if (max < cord)
        {
            max = cord;
        }
        return max;
    }

    static double Define_Max(int num, long key, float cord, double res)
    {
        double max = 0;
        max = num;
        if (max < key)
        {
            max = key;
        }
        if (max < cord)
        {
            max = cord;
        }
        if (max < res)
        {
            max = res;
        }
        return max;
    }

    static double Define_Min(int num, long key)
    {
        double min = 0;
        min = num;
        if (key < num)
        {
            min = key;
        }
        return min;
    }

    static double Define_Min(int num, long key, float cord)
    {
        double min = 0;
        min = num;
        if (key < num)
        {
            min = key;
        }
        if (cord < num)
        {
            min = cord;
        }
        return min;
    }

    static double Define_Min(int num, long key, float cord, double res)
    {
        double min = 0;
        min = num;
        if (key < num)
        {
            min = key;
        }
        if (cord < num)
        {
            min = cord;
        }
        if (res < num)
        {
            min = res;
        }
        return min;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Define_Max(23, 76));
        Console.WriteLine(Define_Max(23, 76, 88.88f));
        Console.WriteLine(Define_Max(23, 76, 88.88f, 99.99));
        Console.WriteLine(Define_Min(99, 77));
        Console.WriteLine(Define_Min(99, 77, 55.55f));
        Console.WriteLine(Define_Min(99, 77, 55.55f, 33.33));
    }
}