namespace StrategyTest.Operation
{
	public interface IOperation
	{
		int Execute(int num1, int num2);
	}

	public class Add : IOperation
	{
		public int Execute(int num1, int num2)
		{
			return num1 + num2;
		}
	}

	public class Subtract : IOperation
	{
		public int Execute(int num1, int num2)
		{
			return num1 - num2;
		}
	}

	public class Mul : IOperation
	{
		public int Execute(int num1, int num2)
		{
			return num1 * num2;
		}
	}

	public class Divide : IOperation
	{
		public int Execute(int num1, int num2)
		{
			return num1 / num2;
		}
	}
}