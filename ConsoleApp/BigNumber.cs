namespace ConsoleApp;

public class BigNumber
{
    private const string Zero = "0";

    private readonly string _number;

    public BigNumber()
    {
        _number = Zero;
    }

    public BigNumber(string number)
    {
        _number = number;
    }

    public static BigNumber operator +(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        // ToDo: implement
        return new BigNumber();
    }

    public static BigNumber operator -(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        // ToDo: implement
        return new BigNumber();
    }

    public static BigNumber operator *(BigNumber bigNumber1, BigNumber bigNumber2)
    {
        // ToDo: implement
        return new BigNumber();
    }

    public override string ToString()
    {
        return _number;
    }
}