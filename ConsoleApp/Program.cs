internal class Program
{
    private static void Main(string[] args)
    {
        // With Extra task
        Console.WriteLine("This is a program to calculate the sum between two numbers");
        int x, y;
        int sum = 0;
        Console.WriteLine("Please declare values for X: ");
        string variableX = Console.ReadLine();
        if (int.TryParse(variableX, out x))
        {
            Console.WriteLine($"X = {x}");
            Console.WriteLine("Please declare values for Y: ");
            string variableY = Console.ReadLine();

            if (int.TryParse(variableY, out y))
            {
                Console.WriteLine($"Y = {y}");
                Console.WriteLine("Press any key to proceed");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine($"x = {x} y = {y}");
                if (x < y)
                {
                    for (int i = x; i <= y; ++i)
                    {
                        sum += i;
                    }
                    Console.WriteLine("first condition"); // to check, which condition works 
                }
                else if (x > y) // x = 5, y = 2
                {
                    for (int i = y; i <= x; ++i)
                    {
                        sum += i;
                    }
                    Console.WriteLine("second condition"); // to check, which condition works 
                }
                else
                {
                    sum = x;
                }
                Console.WriteLine($"The sum of numbers from X to Y is {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}