namespace Homework
{
    class Program
    {
        static int MaxValue(int firstValue, int secondValue)
        {
            int max = 0;
            max = firstValue > secondValue ? firstValue : secondValue;
            return max;
        }

        static int MaxValue(int firstValue, int secondValue, int thirdValue)
        {
            int max = 0;
            max = firstValue > secondValue ? firstValue : secondValue;
            max = max > thirdValue ? max : thirdValue;
            return max;
        }

        static int MaxValue(int firstValue, int secondValue, int thirdValue, int fourthValue)
        {
            int max = 0;
            max = firstValue > secondValue ? firstValue : secondValue;
            max = max > thirdValue ? max : thirdValue;
            max = max > fourthValue ? max : fourthValue;
            return max;
        }

        static int MinValue(int firstValue, int secondValue)
        {
            if (firstValue < secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        static int MinValue(int firstValue, int secondValue, int thirdValue)
        {
            int min = 0;
            min = firstValue < secondValue ? firstValue : secondValue;
            min = min < thirdValue ? min : thirdValue;
            return min;

        }

        static int MinValue(int firstValue, int secondValue, int thirdValue, int fourthValue)
        {
            int min = 0;
            min = firstValue < secondValue ? firstValue : secondValue;
            min = min < thirdValue ? min : thirdValue;
            min = min < fourthValue ? min : fourthValue;
            return min;
        }

        static bool TrySumIfOdd(int firstParam, int secondParam, out int sum)
        {
            sum = firstParam + secondParam;
            if (sum % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Repeat( string teststr, int count)
        {
            string repstring = "";
            if (count > 0 && teststr != "")
            {
                for (int i = 0; i < count; i++)
                {
                repstring += teststr;
                }               
            }
            else
            {
                Console.WriteLine("Perevirte vvedeni dani, i sprobuyte sche");
            }
            return repstring;
        }
        static void Main(string[] args)
        {

            /*  тестування max/min

            Console.WriteLine(MaxValue(11111, 33, 51));
            Console.WriteLine(MaxValue(11111, 42333, 251,1241));
            Console.WriteLine(MaxValue(11111, 42333));
            Console.WriteLine(MinValue(11111, 43, 125251));
            Console.WriteLine(MinValue(11111, 42333, 125251, 1241));
            Console.WriteLine(MinValue(11111, 433));
            */
            int sum, firstParam = 0, secondParam = 0;

            Console.WriteLine("TrySumIfOdd method");
            Console.WriteLine();
            Console.WriteLine("Vvedit' pershiy parametr");

            if (int.TryParse(Console.ReadLine(), out firstParam))
            {
                Console.WriteLine("Vvedit'  parametr");
                if (int.TryParse(Console.ReadLine(), out secondParam))
                {
                    Console.WriteLine($"STATUS : {TrySumIfOdd(firstParam, secondParam, out sum)}");

                    Console.WriteLine($"SUM is: {sum}");
                }
                else
                {
                    Console.WriteLine("Nevirniy drugiy parametr");
                }
            }
            else
            {
                Console.WriteLine("Nevirniy pershiy parametr, dlya vvodu drugogo parametru potribno korrektno vvesty pershiy");
            }

            //EXTRA
            Console.WriteLine();
            Console.WriteLine("EXTRA ");
            Console.WriteLine();

            int count = 0;
            string teststr;

            Console.WriteLine("vvedit' symvoly, yaki budut' povtoryuvatis");

            teststr = Console.ReadLine();

            Console.WriteLine("Vvedit' skil'ki raziv treba povtoriti tekst (chislo)");

            int.TryParse(Console.ReadLine(), out count);

            Console.WriteLine(Repeat(teststr, count)); 

        }
    } 
}