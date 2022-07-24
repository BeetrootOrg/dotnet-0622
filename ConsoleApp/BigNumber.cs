namespace ConsoleApp;
using static System.Console;
using System.Text;

class BigNumber
{
    private readonly string _number;

    public BigNumber()
    {
        _number = "0";
    }

    public BigNumber(string number)
    {
        _number = number;
    }

    private static void TrimNumbers (ref string number1, ref string number2)
    {
        number1 = number1.TrimStart('0');
        number2 = number2.TrimStart('0');
        if (number1.Length == 0) number1 = "0"; 
        if (number2.Length == 0) number2 = "0"; 
    }
 
    private static bool NumberComparing(string number1, string number2)
    {
        if (number1.Length > number2.Length)
        {
            return true;
        }

        if (number2.Length > number1.Length)
        {
            return false;
        }

        for (int i = 0; i < number1.Length; i++)
        {
            int.TryParse(number1[i].ToString(), out int num1);
            int.TryParse(number2[i].ToString(), out int num2);

            if (num1 > num2) return true;
            if (num1 < num2) return false;
        }
        return true;
    }


    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();

        bool isNegative = false, firstNegative = false, secondNegative = false;

        if (number1[0] == '-')
        {
            firstNegative = true;
            number1 = number1.Substring(1);
        }

        if (number2[0] == '-')
        {
            secondNegative = true;
            number2 = number2.Substring(1);
        }

        if (firstNegative && secondNegative) isNegative = true;

        if (firstNegative && !secondNegative)
            return new BigNumber(number2) - new BigNumber(number1);
        else if (!firstNegative && secondNegative)
            return new BigNumber(number1) - new BigNumber(number2);

        string maxNumber, minNumber;
        int maxLength, minLength;

        TrimNumbers(ref number1, ref number2);

        if(NumberComparing(number1, number2))
        {
            maxLength = number1.Length;
            maxNumber = number1;
            minLength = number2.Length;
            minNumber = number2;
        }
        else
        {
            maxLength = number2.Length;
            maxNumber = number2;
            minLength = number1.Length;
            minNumber = number1;
        }

        int addLater = 0;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            char symbol;
            int num1 = 0, num2 = 0;

            if (i < minLength)
            {
                symbol = minNumber[minLength - 1 - i];

                int.TryParse(symbol.ToString(), out num1);
            }

            symbol = maxNumber[maxLength - 1 - i];

            int.TryParse(symbol.ToString(), out num2);

            int tempResult = num1 + num2 + addLater;

            if (tempResult >= 10)
            {
                addLater = 1;
                tempResult = tempResult - 10;
            }
            else
            {
                addLater = 0;
            }
            result.Insert(0, tempResult);
        }

        if (addLater != 0) result.Insert(0, addLater);
        if (isNegative) result.Insert(0, '-');

        return new BigNumber(result.ToString());
    }

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();
        string maxNumber, minNumber;
        int maxLength, minLength;
        bool firstNegative = false, secondNegative = false;
    	
         if (number1[0] == '-')
        {
            firstNegative = true;
            number1 = number1.Substring(1);
        }

        if (number2[0] == '-')
        {
            secondNegative = true;
            number2 = number2.Substring(1);
        }

        TrimNumbers(ref number1, ref number2);

        if (firstNegative && secondNegative) return new BigNumber(number2) - new BigNumber(number1);

        if (firstNegative && !secondNegative)
        {
         var positiveResult = new BigNumber(number2) + new BigNumber(number1);   
         
         if(positiveResult.ToString()[0] == '0') return new BigNumber(positiveResult.ToString());
         
         return new BigNumber('-' + positiveResult.ToString());
        }


        bool isFirstBigger = NumberComparing(number1, number2);

        if (isFirstBigger)
        {
            maxLength = number1.Length;
            maxNumber = number1;
            minLength = number2.Length;
            minNumber = number2;
        }
        else
        {
            maxLength = number2.Length;
            maxNumber = number2;
            minLength = number1.Length;
            minNumber = number1;
        }

        int deductLater = 0;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < maxLength; i++)
        {
            char symbol;
            int num1 = 0, num2 = 0;

            symbol = maxNumber[maxNumber.Length - 1 - i];

            int.TryParse(symbol.ToString(), out num1);


            if (i < minNumber.Length)
            {
                symbol = minNumber[minNumber.Length - 1 - i];

                int.TryParse(symbol.ToString(), out num2);
            }

            int tempResult = num1 - num2 + deductLater;

            if (tempResult < 0)
            {
                deductLater = -1;
                tempResult = tempResult + 10;
            }
            else
            {
                deductLater = 0;
            }
            result.Insert(0, tempResult);
        }

        while (result[0] == '0' && result.Length != 1)
            result.Remove(0, 1);
    
        if (!isFirstBigger) result.Insert(0, '-');

        return new BigNumber(result.ToString());
    }

    public static BigNumber operator *(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();

        bool isNegative = false;

        if (number1[0] == '-')
        {
            isNegative = true;
            number1 = number1.Substring(1);
        }

        if (number2[0] == '-')
        {
            isNegative = (isNegative == true) ? false : true;
            number2 = number2.Substring(1);
        }

        TrimNumbers(ref number1, ref number2);
        
        char symbol;

        int num1 = 0, num2 = 0, addLater = 0;

        var result = new BigNumber();

        for (int i = 0; i < number1.Length; i++)
        {
            StringBuilder subResult = new StringBuilder();

            if (i > 0) subResult.Insert(0, new string('0', i));

            symbol = number1[number1.Length - 1 - i];
            int.TryParse(symbol.ToString(), out num1);
            int tempResult = 0;

            for (int j = 0; j < number2.Length; j++)
            {

                symbol = number2[number2.Length - 1 - j];
                int.TryParse(symbol.ToString(), out num2);
                tempResult = num1 * num2 + addLater;

                if (tempResult >= 10 && number2.Length != j + 1)
                {
                    addLater = tempResult / 10;
                    tempResult = tempResult - 10;
                }
                else
                {
                    addLater = 0;
                }
                subResult.Insert(0, tempResult);
            }

            var subBigResult = new BigNumber(subResult.ToString());
            result += subBigResult;
        }

        if (isNegative) result = new BigNumber('-' + result.ToString());

        return result;
    }

    public override string ToString()
    {
        return _number.ToString();
    }
}