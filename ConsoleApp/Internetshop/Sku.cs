namespace ConsoleApp.Internetshop;
using static System.Console;


class Sku : SkuAbst
{
    override public void AddNewSku()
    {
        System.Console.WriteLine("Set FullName");
        FullName = ReadLine();
        System.Console.WriteLine("Set ShortName");
        ShortName = ReadLine();
        System.Console.WriteLine("Set Price");
        InPrice = ReadLine();

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