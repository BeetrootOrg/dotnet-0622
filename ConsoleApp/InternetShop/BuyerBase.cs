class BuyerBase : BuyerManagement
{
    private Buyer[]? Buyers { get; set; }
    public BuyerBase(Buyer[] buyers)
    {
        Buyers = buyers;
    }
    public override object AddBuyer()
    {
        throw new NotImplementedException();
    }
    public override void RemoveBuyer()
    {
        throw new NotImplementedException();
    }
    public override void UpdateBuyerInfo()
    {
        throw new NotImplementedException();
    }
}