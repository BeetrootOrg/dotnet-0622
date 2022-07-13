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

    public static BigNumber operator +(BigNumber bigNumber)
    {
        // sum result;
        return new BigNumber();
    }

    public static BigNumber operator -(BigNumber bigNumber)
    {
        // sum result;
        return new BigNumber();
    }

    public static BigNumber operator *(BigNumber bigNumber)
    {
        // sum result;
        return new BigNumber();
    }
}