using System;

namespace StrategyTest.Helper
{
	public class Arguments
	{
		public int Number1 { get; init; }
		public int Number2 { get; init; }
		public char Operator { get; init; }
	}

	public class ArgumentsParser
	{
		public static Arguments ToArguments(string input)
		{
			string[] splitted = input.Split(new[] { '+', '-', '/', '*' });
			return splitted.Length != 2
				? throw new ArgumentException("Wrong input")
				: !int.TryParse(splitted[0], out int num1) || !int.TryParse(splitted[1], out int num2)
				? throw new ArgumentException("Wrong input")
				: new Arguments
				{
					Number1 = num1,
					Number2 = num2,
					Operator = input[splitted[0].Length]
				};
		}
	}
}