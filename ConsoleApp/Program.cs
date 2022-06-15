//03-conditions
//HOMEWORK
// Not your boring middle school homework — these tasks will help you in real life! Have fun with your assignment for this topic:
// Create a program that will start with declaration of two constants (X and Y) and will count the sum of all numbers between these constants. If they are equal then sum should be one of them
// Example:
// X=10
// Y=12
// Sum=10+11+12=33
//
// X=5
// Y=2
// Sum=2+3+4+5=14
//
// X=10
// Y=10
// Sum=10
//
// Extra:
// Read values of X and Y from the console. If output is invalid - write to console Invalid input and exit the program.

int x =0;
int y = 0;
int num = 0;
long sum = 0;

System.Console.WriteLine("Please input X: ");
if (int.TryParse(Console.ReadLine(), out x))
{
    System.Console.WriteLine("Please input Y: ");
    if (int.TryParse(Console.ReadLine(), out y))
    {
         if (x < y)
        {
            num = y - x;
            while(num > -1)
            {
                sum += y - num;
                --num;
            }
        }
        else
        {
            num = x - y;
            while(num > -1)
            {
                sum += x - num;
                --num;
            }
        }   
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
//System.Console.WriteLine ($"X = {x}, Y = {y}, Sum = {sum}, Num = {num}");
