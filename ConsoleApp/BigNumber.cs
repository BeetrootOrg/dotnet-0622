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

    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        string number1 = bigNumber1._number.ToString();
        string number2 = bigNumber2._number.ToString();
        string maxNumber, minNumber;
        int maxLength, minLength;
        if(number1.Length > number2.Length)
        {
            maxLength = number1.Length;
            maxNumber = number1;
            minLength = number2.Length;
            minNumber = number2;
        } else
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

            if(i < minLength)
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
                tempResult = tempResult - 10 ;        
            }
            else 
            {
                addLater = 0;       
            }
            result.Insert(0, tempResult); 
        }
        
        if (addLater !=0) result.Insert(0, addLater); 

        return new BigNumber(result.ToString());
    }

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        // sum result;
        return new BigNumber();
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