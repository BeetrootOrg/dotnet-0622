namespace ConsoleApp.Internetshop;

class Store : SkuAbst
{
    public Employer Mol { get; set; }
    public Sku SkuStore { get; set; }
    public int Amount { get; set; }
    public bool IsComing { get; set; }

    override public void AddNewSku()
    {
        System.Console.WriteLine(" New sku added to store... ");
    }

    override public void DeleteSku()
    {
        throw new NotImplementedException();
    }
    override public void SearchSku()
    {
        throw new NotImplementedException();
    }
}