namespace ConsoleApp.InternetShopHW;

class PlayStationFive : Product
{
    public bool IsDigitalEdition { get; init; }
    public override Receipt SellProduct(IBuyable customer)
    {
        --Quantity;
        Receipt receiptToReturn = new Receipt(Price, this, customer);
        if (customer is Worker)
        {
            receiptToReturn.FinalPrice *= 0.9;
        }
        return receiptToReturn;
    }
}