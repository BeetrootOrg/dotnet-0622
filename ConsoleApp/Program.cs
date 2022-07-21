namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new BigNumber("123");
            var b = new BigNumber("123");
            
            Console.WriteLine((a*b).ToString());
		}
	}
}