namespace ConsoleApp.Internetshop;

class SkuAbst : ISku
{
    public string FullName;
    public string ShortName;
    public string InPrice;



    virtual public void AddNewSkuToStore()
    {
        System.Console.WriteLine("base realisation... ");
    }

    virtual public void AddNewSku()
    {
        System.Console.WriteLine("base realisation... ");
    }

    virtual public void DeleteSku()
    {
        throw new NotImplementedException();
    }

    virtual public void SearchSku()
    {
        throw new NotImplementedException();
    }
}