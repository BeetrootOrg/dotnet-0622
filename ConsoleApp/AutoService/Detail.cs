class Detail
{
    public string BrandOfDetail { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public Detail(string typeOfDetail, decimal price, int quantity)
    {
        BrandOfDetail = typeOfDetail;
        Price = price;
        Quantity = quantity; 
    }
    public override string ToString()
    {
        return $"Type of detail: {BrandOfDetail}. Price: {Price}. Quantity: {Quantity}";
    }
}