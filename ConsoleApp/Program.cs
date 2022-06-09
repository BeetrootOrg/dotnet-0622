// With Extra task
System.Console.WriteLine("This is a program to calculate the sum between two numbers");
int x, y;
int sum = 0;
System.Console.WriteLine("Please declare values for X: ");
string variableX = Console.ReadLine();
if (int.TryParse(variableX, out x))
{
    System.Console.WriteLine($"X = {x}");
    System.Console.WriteLine("Please declare values for Y: ");
    string variableY = Console.ReadLine();

    if (int.TryParse(variableY, out y))
    {
        System.Console.WriteLine($"Y = {y}");
        System.Console.WriteLine("Press Enter to proceed");
        System.Console.ReadKey();
        System.Console.WriteLine();
        System.Console.WriteLine($"x = {x} y = {y}");
        if (x < y)
        {
            for (int i = x; i <= y; ++i)
            {
                sum += i;
            }
            System.Console.WriteLine("first condition"); // to check, which condition works 
        }
        else if (x > y) // x = 5, y = 2
        {
            for (int i = y; i <= x; ++i)
            {
                sum += i;
            }
            System.Console.WriteLine("second condition"); // to check, which condition works 
        }
        else
        {
            sum = x;
        }
        System.Console.WriteLine($"The sum of numbers from X to Y is {sum}");
    }
    else
    {
        System.Console.WriteLine("Invalid input");
    }
}
else
{
    System.Console.WriteLine("Invalid input");
}