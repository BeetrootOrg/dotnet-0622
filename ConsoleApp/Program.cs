using System.Text.RegularExpressions; 			
public class Program
{
	public static void Main()
	{
		SumNumbers();
	}
	
	private static void SumNumbers()
	{
		int fNumber, sNumber;
		Console.WriteLine("\nPlease, enter the first number: ");
		do
		{
			var input1 = Console.ReadLine();
			if (Regex.IsMatch(input1, @"^\d+$")) // ^ beginning of string, \d single digit, $ end of string
			{
				fNumber = Convert.ToInt32(input1); 
                break;
			}
			else
			{
				Console.WriteLine("Input provided is invalid. Please enter a correct first integer number and run again ");
                return;
			}
		} while (true);

		Console.WriteLine("\nPlease,enter second number: ");
		do
		{
			var input2 = Console.ReadLine();
			if (Regex.IsMatch(input2, @"^\d+$")) // ^ beginning of string, \d single digit, $ end of string
			{
				sNumber = Convert.ToInt32(input2); 
                break;
			}
			else
			{
				Console.WriteLine("Input provided is invalid. Please enter a correct second integer number and run again ");
                return;
			}
		} while (true);

		int min = Math.Min(fNumber, sNumber);
		int max = Math.Max(fNumber, sNumber);
		int result = 0;
		for (int i = min; i <= max; i++)
		{
			result = result + i;
		}

		Console.WriteLine("The sum of Numbers between " + min + " and " + max + " is: " + result.ToString());
	}
}