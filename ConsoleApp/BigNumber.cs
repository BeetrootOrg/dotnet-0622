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

    private static bool NumberComparing (BigNumber bigNumber1, BigNumber bigNumber2)
    {   
        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();
    
        if (number1.Length > number2.Length)
        {   
            return true;
        }

        if(number2.Length > number1.Length)
        {
            return false;
        }
        
        for (int i = 0; i < number1.Length; i++)
        {
           int.TryParse(number1[i].ToString(), out int num1);
           int.TryParse(number2[i].ToString(), out int num2);

           if(num1 > num2) return true;
           if(num1 < num2) return false;
        }
        return true;       
    }

        
    
    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        bool isFirstBigger = NumberComparing(bigNumber1, bigNumber2);

        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();
        string maxNumber, minNumber;
        int maxLength, minLength;
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

        return new BigNumber(result.ToString());
    }

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        
        bool isFirstBigger = NumberComparing(bigNumber1, bigNumber2);

        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();
        string maxNumber, minNumber;
        int maxLength, minLength;
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

        if (!isFirstBigger) result.Insert(0, '-');

        return new BigNumber(result.ToString());
    }

    public static BigNumber operator *(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        // sum result;
        return new BigNumber();
    }

    public override string ToString()
    {
        return _number.ToString();
    }
}