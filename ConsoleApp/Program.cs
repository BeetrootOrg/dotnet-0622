﻿/*
Define and call with different parameters next methods:

   1) Method that will return max value among all the parameters
   2) … min value …
   3) Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false, sum return as out parameter
   4) Overload first two methods with 3 and 4 parameters

*/

internal class Program
{//1 and 2
        static int MaxMath(int numb1, int numb2)
        {
            int result;
            if (numb1 > numb2)
            {
                result = numb1;
            }

            else
            {
                result = numb2;
            }
            return result;
        }


        static int MinMath(int numb1, int numb2)
        {
            int result;
            if (numb1 > numb2)
            {
                result = numb2;

            }

            else
            {
                result = numb1;
            }
            return result;
        }
        // завдання 4 - перевантаження для MinMath MaxMath
        static int MaxMath(int numb1, int numb2, int numb3)
        {
            int resultOn3End;
            int resultOn31;

            if (numb1 > numb2)
            {
                resultOn31 = numb1;
            }

            else
            {
                resultOn31 = numb2;
            }
            
            if (resultOn31 > numb3)
            {
                resultOn3End = resultOn31;
            }
           else
            {
                resultOn3End = numb3;
            }
             return resultOn3End;
        }

        static int MinMath(int numb1, int numb2, int numb3)
        {
            int resultOn3End;
            int resultOn31;

            if (numb1 > numb2)
            {
                resultOn31 = numb2;
            }

            else
            {
                resultOn31 = numb1;
            }
            
            if (resultOn31 > numb3)
            {
                resultOn3End = numb3;
            }
           else
            {
                resultOn3End = resultOn31;
            }
             return resultOn3End;
        }

        static int MaxMath(int numb1, int numb2, int numb3, int numb4)
        {
            int resultOn3End;
            int resultOn31;
            int resultOn32;

            if (numb1 > numb2)// спочатку порівняємо перший і другий в результат переможця запишем
            {
                resultOn31 = numb1;
            }

            else
            {
                resultOn31 = numb2;
            }
            
            if (numb3 > numb4)// потім  порівняємо третій і четвертий в результат переможця запишем
            {
                resultOn32 = numb3;
            }
           else
            {
                resultOn32 = numb4;
            }
            if (resultOn31 > resultOn32)
             {
            resultOn3End = resultOn31;
             }
            else
            {
                resultOn3End = resultOn32;
            }

             return resultOn3End;
        }



        /*
        далі завдання номер 3 
        Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false, sum return as out parameter
        */
        static bool TrySumIfOdd(int param1, int param2, out int sum)

        {
            int startValue = 0;
            int endValue = 0;
            sum = 0;
            if (param1 > param2)
            {
                startValue = param2;
                endValue = param1;
            }
            else if (param1 < param2)
            {
                startValue = param1;
                endValue = param2;
            }
            else
            {
                Console.WriteLine("both params are equal");
            }

            int countTimes = endValue - startValue;
            for (int i = 0; i <= countTimes; ++i)
            {
                sum = sum + startValue;
                startValue = startValue + 1;
            }


            if (sum % 2 == 0)
            {
                Console.WriteLine("результат false");
                return false;
            }
            Console.WriteLine("результат true");
            return true;
        }


    static void Main(string[] args)
    {
       // int numb1, numb2;
        int numb1 = 9;
        int numb2 = 23;
        
        int sumBetweenTwo = 0;
        int param1 = 10;
        int param2 = 12;
        int countTimes = 0;
        

        int numb3 = 14;
        int numb4 = 45;



     //   numb1 = int.Parse(Console.ReadLine());
     //   numb2 = int.Parse(Console.ReadLine());
        Console.WriteLine("MaxMath для двох чисел");
        Console.WriteLine(MaxMath(numb1, numb2));
        Console.WriteLine("MinMath для двох чисел");
        Console.WriteLine(MinMath(numb1, numb2));

        
        Console.WriteLine("TrySumIfOdd для двох чисел");
        TrySumIfOdd(param1, param2, out sumBetweenTwo);
        Console.WriteLine(sumBetweenTwo);
    // перевантаження для інших варіантів MaxMath/MinMath
        Console.WriteLine("MaxMath для 3 чисел");
        Console.WriteLine(MaxMath(numb1, numb2, numb3));
        Console.WriteLine("MinMath для 3 чисел");
        Console.WriteLine(MinMath(numb1, numb2, numb3));
        Console.WriteLine("MaxMath для 4 чисел");
        Console.WriteLine(MaxMath(numb1, numb2, numb3, numb4));



    }
}