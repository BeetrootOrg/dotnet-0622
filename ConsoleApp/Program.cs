namespace ConsoleApp.Internetshop;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Client MyClient1 = new Client();
        MyClient1.AddNewPerson();

        Employer MyEmployer1 = new Employer();
        MyEmployer1.AddNewPerson();

        Sku Sku1 = new Sku();
        Sku1.AddNewSku();

        
    }
}