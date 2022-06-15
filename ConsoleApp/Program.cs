Console.WriteLine("choose number x:");
int x;
bool checkX = int.TryParse(Console.ReadLine(),out x);

Console.WriteLine("choose number y:");
int y;
bool checkY = int.TryParse(Console.ReadLine(), out y);

if(checkX & checkY)
{
    switch(x == y)
    {
        case true:
            {
                Console.WriteLine($"Sum {x}");
                break;
            }
        case false:
            {
                int biggest = x > y ? x : y;
                int smallest = x < y ? x : y;
                int sum = 0;
                while (smallest + 1 < biggest)
                    {
                        sum += smallest + 1;
                        ++smallest;
                    }
                Console.WriteLine("Sum: " + sum);
                break;
            }
    }
}
else
{
    Console.WriteLine("Invalid input.");
}