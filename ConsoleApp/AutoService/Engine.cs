class Engine : Detail
{
    public string EngineBrand { get; set; }
    public decimal EnginePrice { get; set; }
    public int EngineAmount { get; set; }
    public Engine(string engineBrand, decimal enginePrice, int engineAmount) : base(engineBrand, enginePrice, engineAmount)
    {
        EngineBrand = engineBrand;
        EnginePrice = enginePrice;
        EngineAmount =engineAmount;
    }
}