class Receipt
{
    public Product? ProductInfo { get; set; }
    public Buyer? BuyerInfo { get; set; }
    public Receipt(Product productInfo, Buyer buyerInfo)
    {
        ProductInfo = productInfo;
        BuyerInfo = buyerInfo;
    }
    public object CreateReceipt() => throw new NotImplementedException();
}