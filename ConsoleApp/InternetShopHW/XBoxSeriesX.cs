namespace ConsoleApp.InternetShopHW;

class XBoxSeriesX : Product
{
    public bool hasKinect { get; set; }
    public override Receipt SellProduct(IBuyable customer)
    {
        --Quantity;
        Receipt receiptToReturn = new Receipt(Price, this, customer);
        if (customer is Worker)
        {
            receiptToReturn.FinalPrice *= 0.7;
        }
        return receiptToReturn;
    }
}