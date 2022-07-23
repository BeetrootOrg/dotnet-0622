class Buyer : Person
{
    private string? BuyerFirstName { get; set; }
    private string? BuyerLastName { get; set; }
    private int BuyerAge { get; set; }
    public Buyer(string buyerFirstName, string buyerLastName, int buyerAge) : base(buyerFirstName, buyerLastName, buyerAge)
    {
        BuyerFirstName = buyerFirstName;
        BuyerLastName = buyerLastName;
        BuyerAge = buyerAge;
    }
}