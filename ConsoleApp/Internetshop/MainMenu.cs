namespace ConsoleApp.Internetshop;
using static System.Console;
using System;
using System.IO;
using System.Text;


class MainMenu : IMeinMenu
{

    private void AdminMenu()
    {
        Clear();
        WriteLine();
        WriteLine("Please choose: ");
        WriteLine("\t1 - AddNewSkuToTheBase");
        WriteLine("\t2 - RegBuyer");
        // WriteLine("\t3 - RegBuyer");
        WriteLine("\t0 - Exit");

        //const string filenameBuyer = "databuyer.csv";

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                WriteLine();
                Clear();
                FirstMenu();
                break;
            case ConsoleKey.D1:
                WriteLine();
                System.Console.WriteLine("AddNewSkuToTheBase");
                Sku MySku = new Sku();
                MySku.AddNewSku();
                break;
            case ConsoleKey.D2:
                WriteLine();
                System.Console.WriteLine("RegBuyer");
                Client MyClient = new Client();
                MyClient.AddNewPerson();
                break;
        }
    }

    private void ClientMenu()
    {
       
        Clear();
        System.Console.WriteLine("ClientMenu entered");
        WriteLine();
        WriteLine("Please choose: ");
        WriteLine("\t1 - Add preorder");
        WriteLine("\t2 - See All Goods");
        // WriteLine("\t3 - RegBuyer");
        WriteLine("\t0 - Exit");

        //const string filenameBuyer = "databuyer.csv";

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                WriteLine();
                Clear();
                FirstMenu();
                break;
            case ConsoleKey.D1:
            System.Console.WriteLine("Add preorder");
                WriteLine();
                System.Console.WriteLine("Add preorder");
                // Sku MySku = new Sku();
                // MySku.AddNewSku();
                break;
            case ConsoleKey.D2:
            System.Console.WriteLine("See All Goods");
                WriteLine();
                System.Console.WriteLine("See All Goods");
                // Client MyClient = new Client();
                // MyClient.AddNewPerson();
                break;
        }

    }

    public void ExitMenu()
    {
        Environment.Exit(0);
    }

    public void FirstMenu()
    {
        WriteLine("Welcome internet store");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("\t1 - Administrator access");
        WriteLine("\t2 - Client access");
        WriteLine("\t0 or ane key - Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                Clear();
                ExitMenu();
                break;
            case ConsoleKey.D1:
                while (true)
                {
                    AdminMenu();
                }
                break;

            case ConsoleKey.D2:
                Clear();
                while (true)
                {
                    ClientMenu();
                }
                break;

            default:
                break;
        }
    }
}