using System.Numerics;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
            string number1 = "12345678910111213141516";
            string number2 = "987654321";

			var a = new BigNumber(number1);
            var b = new BigNumber(number2);

            BigInteger x = 0, y =0;
            x = BigInteger.Parse(number1);
            y = BigInteger.Parse(number2);

            
            Console.WriteLine("{0,30}",(a*b).ToString());
            Console.WriteLine("{0,30}",x*y);
		}
	}
}