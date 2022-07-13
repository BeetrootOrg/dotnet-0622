namespace ConsoleApp.Internetshop;
using static System.Console;


class Sku : SkuAbst
{

    const string filenameSku = "datasku.csv";
    override public void AddNewSku()
    {
        WriteLine("Set FullName");
        FullName = ReadLine();
        WriteLine("Set ShortName");
        ShortName = ReadLine();
        WriteLine("Set Price");
        InPrice = ReadLine();
        string Serialize((string FullName, string ShortName, string InPrice) row) => $"{row.FullName},{row.ShortName},{row.InPrice}";
        File.AppendAllLines(filenameSku, new[] { Serialize((FullName, ShortName, InPrice)) });
        
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