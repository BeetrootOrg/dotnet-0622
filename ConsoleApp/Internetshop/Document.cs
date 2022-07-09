namespace ConsoleApp.Internetshop;

abstract class Document : IDocument
{
    string NumberDoc { get; set; }
    DateTime DataDoc { get; set; }
    Seller SellerDoc { get; set; }
    Client Buyer { get; set; }

    virtual public void DeleteDocument()
    {
        throw new NotImplementedException();
    }

    virtual public void EditDocument()
    {
        throw new NotImplementedException();
    }

    virtual public void FindDocument()
    {
        throw new NotImplementedException();
    }

    virtual public void MakeNewDocument()
    {
        Console.WriteLine("New DOCUMENT added ... ");
    }
}