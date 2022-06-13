var random = new Random((int)DateTime.Now.Ticks);
System.Console.WriteLine(random.Next());
System.Console.WriteLine(random.Next(100));
System.Console.WriteLine(random.Next(50, 150));

System.Console.WriteLine(random.NextDouble());
// from 30 to 100: [30; 100)
System.Console.WriteLine(random.NextDouble() * 70 + 30); // random * (length of values) + minValue

// from 0 to 100: [0; 100)
System.Console.WriteLine(random.NextDouble() * 100);

const double probability = 100 / 6f;
while (true)
{
    var chance = random.NextDouble() * 100;
    if (chance < probability)
    {
        System.Console.WriteLine("You're killed");
        break;
    }
    else
    {
        System.Console.WriteLine("You're alive");
    }

    Console.ReadKey();
}

// 1. create method void WriteLine(int n) and write to console numbers from 1 to n using recurssion
// 2. create method int Factorial(int n) that will count n! = n * (n - 1) * (n - 2) * ... * 2 * 1, e.g. 5! = 5 * 4 * 3 * 2 * 1 = 120;