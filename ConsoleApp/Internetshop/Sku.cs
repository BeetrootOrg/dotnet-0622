namespace ConsoleApp.Internetshop;

class Sku : SkuAbst
{
    override public void AddNewSku()
    {
        System.Console.WriteLine("new sku added ...");
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