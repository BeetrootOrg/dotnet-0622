namespace ConsoleApp.Internetshop;
using System;

class Invoice : Document
{
    override public void DeleteDocument()
    {
        throw new NotImplementedException();
    }

    override public void EditDocument()
    {
        throw new NotImplementedException();
    }

    override public void FindDocument()
    {
        throw new NotImplementedException();
    }

    override public void MakeNewDocument()
    {
        Console.WriteLine("New invoice added ... ");
    }
}