using System.Numerics;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
            string number1 = "4564123153452356456756756456";
            string number2 = "335987612453";

			var a = new BigNumber(number1);
            var b = new BigNumber(number2);

            BigInteger x = 0, y =0;
            x = BigInteger.Parse(number1);
            y = BigInteger.Parse(number2);

            
            Console.WriteLine("{0,100}",(a/b).ToString());
            Console.WriteLine("{0,100}",x/y);
		}
	}
}