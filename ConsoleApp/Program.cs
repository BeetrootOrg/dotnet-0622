
System.Console.Write("Input first num(only numbers):");
var num1 = Console.ReadLine();
System.Console.Write("Input second num(only numbers):");
var num2 = Console.ReadLine();

if(num1 == num2) System.Console.WriteLine($"Numbers are equal {num1}"); //or System.Console.WriteLine($"Numbers are equal");

else if (int.TryParse(num1, out int pNumber1) && int.TryParse(num2, out int pNumber2))
{
    GetSum(pNumber1,pNumber2);
}

else
{
    System.Console.WriteLine("You're stupid!");
    System.Console.WriteLine("Press any button to exit the program...");
    Console.ReadKey();
    Environment.Exit(0);
}

 for (var i = 0; i < 10; i++)

            {

                if (i > 5) break;

                Console.Write(i);

            }

void GetSum(int a, int b)
{
    int sum = 0;
    for (int i = Math.Min(a,b); i <= Math.Max(a,b); ++i)
    {
        sum += i;
    }
    System.Console.WriteLine($"Sum from {a} to {b} = {sum}");
}


