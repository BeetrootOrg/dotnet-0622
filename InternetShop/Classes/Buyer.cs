namespace InternetShop.Classes;

internal sealed class Buyer : Person, IBuyer
{
    private protected string IDNumber { get; init; }
    private protected Order[] Orders { get; set; }

    public int GenerateIDNumber()
    {
        throw new NotImplementedException();
    }

    public Order GetOrder(string idNumber)
    {
        throw new NotImplementedException();
    }

    private protected override DateTime GetAge()
    {
        throw new NotImplementedException();
    }

    private protected override string GetCity()
    {
        throw new NotImplementedException();
    }

    private protected override string GetStandartName()
    {
        throw new NotImplementedException();
    }

}