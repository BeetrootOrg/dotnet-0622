/*
Define and call with different parameters next methods:

   1) Method that will return max value among all the parameters
   2) … min value …
   3) Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false, sum return as out parameter
   4) Overload first two methods with 3 and 4 parameters

*/

//1 and 2
static int MaxMath(int numb1, int numb2)
{
int result;
if ( numb1 > numb2 )
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
if ( numb1 > numb2 )
{
   result = numb2;
   
}

else
{
result = numb1;
}
return result;
}

 int numb1, numb2;
 numb1 = int.Parse(Console.ReadLine());
 numb2 = int.Parse(Console.ReadLine());
// MaxMath(numb1, numb2);

System.Console.WriteLine(MaxMath(numb1, numb2)); 
System.Console.WriteLine(MinMath(numb1, numb2)); 


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
    System.Console.WriteLine("param2 < param1");
}
else if (param1 < param2)
{
    startValue = param1;
    endValue = param2;
    System.Console.WriteLine("param1 < param2");

}
else
{
    System.Console.WriteLine("both params are equal");

}

int countTimes = endValue - startValue;

for (int i = 0; i <= countTimes; ++i)
{
    sum = sum + startValue;
    startValue = startValue + 1; 
}
//System.Console.WriteLine(sum);

 if (sum % 2 == 0)
        {
            //result = number / 3;
            System.Console.WriteLine("повернулось четное false");
            System.Console.WriteLine(sum / 2);
            return false;

        }

        //result = 0;
        System.Console.WriteLine("повернулось нечетное true");
        System.Console.WriteLine(sum / 2);

        return true;
        
}








int sumBetweenTwo = 0;

int param1 = 10;
int param2 = 12;
int countTimes = 0; // количество итераций цикла, которое посути равно разнице между значениями, которые ввел юзер
TrySumIfOdd(param1, param2, out sumBetweenTwo);
