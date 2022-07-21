namespace ConsoleApp;

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

    public string ToString()
    {
        return _number;
    }
    
    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1._number[0] != '-' && bigNumber2._number[0] == '-') return (bigNumber1 - bigNumber2);
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] != '-') return (bigNumber2 - bigNumber1);
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] == '-') return (-(-bigNumber1 + -bigNumber2));

        string result = "";
        int temp = 0;
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length < 1+i ? 0 : bigNumber1._number[bigNumber1._number.Length-1-i] - '0';
            int d2 = bigNumber2._number.Length < 1+i ? 0 : bigNumber2._number[bigNumber2._number.Length-1-i] - '0';
            result = result.Insert(0, ((d1+d2+temp)%10).ToString());
            temp = (d1+d2+temp)/10;
        }
        if (temp == 1) result = result.Insert(0, "1");
        return new BigNumber(result);
    }    

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        if (bigNumber1 == bigNumber2) return (new BigNumber("0"));
        if (bigNumber1._number[0] != '-' && bigNumber2._number[0] == '-') return (bigNumber1 + bigNumber2);
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] != '-') return (-(-bigNumber1 + bigNumber2));
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] == '-') return (-bigNumber2-(-bigNumber1));
        if (bigNumber1 < bigNumber2) return (-(bigNumber2-bigNumber1));        

        string result = "";
        int temp = 0;
        for (int i = 0; i < Math.Max(bigNumber1._number.Length, bigNumber2._number.Length); i++)
        {
            int d1 = bigNumber1._number.Length < 1+i ? 0 : bigNumber1._number[bigNumber1._number.Length-1-i] - '0';
            int d2 = bigNumber2._number.Length < 1+i ? 0 : bigNumber2._number[bigNumber2._number.Length-1-i] - '0';
            int subresult = d1+temp>=d2 ? d1+temp-d2 : 10+d1+temp-d2; // <----- fix it!!!
            result = result.Insert(0, subresult.ToString()); 
            temp = d1>=d2 ? 0 : -1;
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
        BigNumber zero = new BigNumber("0");
        if (bigNumber1 == zero || bigNumber2 == zero) return zero;
        if (bigNumber1._number[0] != '-' && bigNumber2._number[0] == '-') return (-(bigNumber1*-bigNumber2));
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] != '-') return (-(-bigNumber1*bigNumber2));
        if (bigNumber1._number[0] == '-' && bigNumber2._number[0] == '-') return (-bigNumber1*-bigNumber2);

        List<BigNumber> subreuslts = new List<BigNumber>();
        for (int i = bigNumber2._number.Length-1; i >= 0; i--)
        {
            int d2 = bigNumber2._number[i] - '0';
            string subresult = "";
            int temp = 0;
            for (int j = bigNumber1._number.Length-1; j >= 0; j--)
            {
                int d1 = bigNumber1._number[j] - '0';
                subresult = subresult.Insert(0, ((d1*d2+temp)%10).ToString());
                temp = (d1*d2+temp)/10;
            }
            if (temp != 0) subresult = subresult.Insert(0, temp.ToString());

            for (int j = i; j < bigNumber2._number.Length-1; j++)
                subresult += "0";
            subreuslts.Add(new BigNumber(subresult));
        }
        
        BigNumber result = new BigNumber("0");
        foreach (var subresult in subreuslts)
            result += subresult;

        return result;
    }

    public static BigNumber operator /(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        return bigNumber1+bigNumber2;
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