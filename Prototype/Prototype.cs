namespace PatternsTest.Prototype
{
	public interface IPrototype<out T>
	{
		T Clone();
	}

	public class TestClassA : IPrototype<TestClassA>
	{
		public int Number { get; init; }
		public string Name { get; init; }

		public TestClassA(int number, string name)
		{
			Number = number;
			Name = name;
		}

		public TestClassA Clone()
		{
			return new TestClassA(Number, Name);
		}
	}
}