namespace Homework
{
    class Program
    {
        static int MaxValue(int firstValue, int secondValue)
        {

            if (firstValue > secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        static int MaxValue(int firstValue, int secondValue, int thirdValue)
        {
            int max = 0;
            if (firstValue > secondValue && firstValue > thirdValue)
            {
                max = firstValue;
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                max = secondValue;
            }
            else if (thirdValue > firstValue && thirdValue > secondValue)
            {
                max = thirdValue;
            }

            return max;

        }
        static int MaxValue(int firstValue, int secondValue, int thirdValue, int fourthValue)
        {
            int max = 0;
            if (firstValue > secondValue && firstValue > thirdValue && firstValue > fourthValue)
            {
                max = firstValue;
            }
            else if (secondValue > firstValue && secondValue > thirdValue && secondValue > fourthValue)
            {
                max = secondValue;
            }
            else if (thirdValue > firstValue && thirdValue > secondValue && thirdValue > fourthValue)
            {
                max = thirdValue;
            }
            else if (fourthValue > firstValue && fourthValue > secondValue && fourthValue > thirdValue)
            {
                max = fourthValue;
            }

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
            int[] temparray = new int[3] { firstValue, secondValue, thirdValue };

            return temparray.Min();

        }

        static int MinValue(int firstValue, int secondValue, int thirdValue, int fourthValue)
        {
            int min = 0;
            min = firstValue > secondValue ? firstValue : secondValue;
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

        static void Repeat( string teststr, int count)
        {
            if (count > 0 && teststr != "")
            {
                for (int i = 0; i < count; i++)
                {
                Console.Write(teststr);
                }
            }
            else
            {
                Console.WriteLine("Perevirte vvedeni dani, i sprobuyte sche");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(MinValue(11111, 42333, 333, 11));     тестування max/min

            int sum, firstParam = 0, secondParam = 0;

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

            int count = 0;
            string teststr;

            Console.WriteLine("vvedit' symvoly, yaki budut' povtoryuvatis");

            teststr = Console.ReadLine();

            Console.WriteLine("Vvedit' skil'ki raziv treba povtoriti tekst (chislo)");

            int.TryParse(Console.ReadLine(), out count);

            Repeat(teststr, count);

        }
    } 
}