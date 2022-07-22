namespace ConsoleApp;

class BigNumber
{
    private readonly string _number;

    public static BigNumber Zero = new BigNumber("0");

    public BigNumber()
    {
        _number = "0";
    }

    public BigNumber(string number)
    {
        _number = number;
    }

    public override string ToString()
    {
        return _number;
    }
    
    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 > Zero && bigNumber2 < Zero) return (bigNumber1 - bigNumber2);
        if (bigNumber1 < Zero && bigNumber2 > Zero) return (bigNumber2 - bigNumber1);
        if (bigNumber1 < Zero && bigNumber2 < Zero) return (-(-bigNumber1 + -bigNumber2));

        string result = "";
        int extra = 0;
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length < 1+i ? 0 : bigNumber1._number[bigNumber1._number.Length-1-i] - '0';
            int d2 = bigNumber2._number.Length < 1+i ? 0 : bigNumber2._number[bigNumber2._number.Length-1-i] - '0';
            result = result.Insert(0, ((d1+d2+extra)%10).ToString());
            extra = (d1+d2+extra)/10;
        }
        if (extra == 1) result = result.Insert(0, "1");
        return new BigNumber(result);
    }    

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2) return Zero;
        if (bigNumber1 > Zero && bigNumber2 < Zero) return (bigNumber1 + bigNumber2);
        if (bigNumber1 < Zero && bigNumber2 > Zero) return (-(-bigNumber1 + bigNumber2));
        if (bigNumber1 < Zero && bigNumber2 < Zero) return (-bigNumber2-(-bigNumber1));
        if (bigNumber1 < bigNumber2) return (-(bigNumber2-bigNumber1));        

        string result = "";
        int extra = 0;
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length < 1+i ? 0 : bigNumber1._number[bigNumber1._number.Length-1-i] - '0';
            int d2 = bigNumber2._number.Length < 1+i ? 0 : bigNumber2._number[bigNumber2._number.Length-1-i] - '0';
            int subresult = d1+extra-d2>=0 ? d1+extra-d2 : 10+d1+extra-d2;
            result = result.Insert(0, subresult.ToString()); 
            extra = d1+extra>=d2 ? 0 : -1;
        }
        while (result[0] == '0')
        {
            result = result.Remove(0,1);
        }
        return new BigNumber(result);
    }

    public static BigNumber operator -(BigNumber bigNumber)
    {
        if (bigNumber._number[0] != '-') return new BigNumber(bigNumber._number.Insert(0, "-"));
        else return new BigNumber(bigNumber._number.Remove(0, 1));
    }

    public static BigNumber operator *(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == Zero || bigNumber2 == Zero) return Zero;
        if (bigNumber1 > Zero && bigNumber2 < Zero) return (-(bigNumber1*-bigNumber2));
        if (bigNumber1 < Zero && bigNumber2 > Zero) return (-(-bigNumber1*bigNumber2));
        if (bigNumber1 < Zero && bigNumber2 < Zero) return (-bigNumber1*-bigNumber2);

        List<BigNumber> subreuslts = new List<BigNumber>();
        for (int i = bigNumber2._number.Length-1; i >= 0; i--)
        {
            int d2 = bigNumber2._number[i] - '0';
            string subresult = "";
            int extra = 0;
            for (int j = bigNumber1._number.Length-1; j >= 0; j--)
            {
                int d1 = bigNumber1._number[j] - '0';
                subresult = subresult.Insert(0, ((d1*d2+extra)%10).ToString());
                extra = (d1*d2+extra)/10;
            }
            if (extra != 0) subresult = subresult.Insert(0, extra.ToString());

            for (int j = i; j < bigNumber2._number.Length-1; j++)
                subresult += "0";
            subreuslts.Add(new BigNumber(subresult));
        }
        
        BigNumber result = new BigNumber("0");
        foreach (var subresult in subreuslts)
            result += subresult;

        return result;
    }

    public static BigNumber Abs(BigNumber bigNumber)
    {
        if (bigNumber._number[0] == '-') return -bigNumber;
        else return bigNumber; 
    }

    public static BigNumber operator /(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber2 == Zero) throw new DivideByZeroException();
        if (bigNumber1 > Zero && bigNumber1 < Zero) return -(-bigNumber1 / bigNumber2);
        if (bigNumber1 < Zero && bigNumber2 > Zero) return -(bigNumber1 / -bigNumber2);
        if (bigNumber1 < Zero && bigNumber2 < Zero) return (-bigNumber1 / -bigNumber2);
        if (bigNumber1 < bigNumber2) return Zero;

        string extra = bigNumber1._number;
        string temp = bigNumber2._number;
        while (extra.Length != temp.Length)
            temp += "0";

        BigNumber numerator = new BigNumber(extra);
        BigNumber denominator = new BigNumber(temp);

        
        string result = "";
        while(denominator._number != "" && denominator >= bigNumber2 )
        {
            int i = 0;
            while(numerator >= denominator)
            {
                numerator -= denominator;
                i++;
            }
            denominator = new BigNumber(denominator._number.Remove(denominator._number.Length-1));
            result = result+i;
        }

        while (result[0] == '0')
        {
            result = result.Remove(0,1);
        }

        return new BigNumber(result);
    }

    public static bool operator <(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2) return false;
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] != '-') return true;
        if (bigNumber1._number[0] != '-' && bigNumber2._number[0] == '-') return false;
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] == '-') return (-bigNumber1>-bigNumber2);
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length+i>=Math.Max(bigNumber1._number.Length, bigNumber2._number.Length) ? bigNumber1._number[bigNumber1._number.Length-Math.Max(bigNumber1._number.Length, bigNumber2._number.Length)+i] - '0' : 0;
            int d2 = bigNumber2._number.Length+i>=Math.Max(bigNumber1._number.Length, bigNumber2._number.Length) ? bigNumber2._number[bigNumber2._number.Length-Math.Max(bigNumber1._number.Length, bigNumber2._number.Length)+i] - '0' : 0;
            if (d1==d2) continue;
            else if (d1 > d2) return false;
            else return true;
        }
        return false;
    }

    public static bool operator >(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2) return false;
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] != '-') return false;
        if (bigNumber1._number[0] != '-' && bigNumber2._number[0] == '-') return true;
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] == '-') return (-bigNumber1<-bigNumber2);
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length+i>=Math.Max(bigNumber1._number.Length, bigNumber2._number.Length) ? bigNumber1._number[bigNumber1._number.Length-Math.Max(bigNumber1._number.Length, bigNumber2._number.Length)+i] - '0' : 0;
            int d2 = bigNumber2._number.Length+i>=Math.Max(bigNumber1._number.Length, bigNumber2._number.Length) ? bigNumber2._number[bigNumber2._number.Length-Math.Max(bigNumber1._number.Length, bigNumber2._number.Length)+i] - '0' : 0;
            if (d1==d2) continue;
            else if (d1 < d2) return false;
            else return true;
        }
        return false;
    }

    public static bool operator <=(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2 || bigNumber1 < bigNumber2) return true;
        else return false;
    }

    public static bool operator >=(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2 || bigNumber1 > bigNumber2) return true;
        else return false;
    }

    public static bool operator ==(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1._number == bigNumber2._number) return true;
        return false;
    }

    public static bool operator !=(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1._number == bigNumber2._number) return false;
        return true;
    }
}