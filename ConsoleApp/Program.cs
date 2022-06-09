internal class Program //Just feels more comfortable with Program and Main)
{
    static int CountSumBetweenIntegers(int fromNumber, int toNumber)
    {
        int sum = 0;

        for (int i = fromNumber; i <= toNumber; ++i)
        {
            sum += i;
        }

        return sum;
    }
    private static void Main(string[] args)
    {
        // Homework with Extra (User Input)
        try
        {
            int sum = 0;
            string finalOutput = "";

            Console.WriteLine("Enter your X:");
            string xStr = Console.ReadLine();
            int x = int.Parse(xStr);

            Console.WriteLine("Enter your Y:");
            string yStr = Console.ReadLine();
            int y = int.Parse(yStr);

            Console.WriteLine($"X = {x}; Y = {y}");

            if (x < y)
            {
                sum = CountSumBetweenIntegers(x, y);
            }
            else if (x > y)
            {
                sum = CountSumBetweenIntegers(y, x);
            }
            else
            {
                sum = x;
            }

            finalOutput = x != y ? $"Sum of numbers between {x} and {y} is {sum}" : $"Both X and Y are equal to {x}";
            Console.WriteLine(finalOutput);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Input");
        }
    }
}