namespace ConsoleApp.Internetshop;

abstract class Document : IDocument
{
    string NumberDoc {get; set;}
    DateTime DataDoc {get; set;}
    Seller SellerDoc {get; set;}
    Client Buyer {get; set;}

    public void DeleteDocument()
    {
        throw new NotImplementedException();
    }

    public void EditDocument()
    {
        throw new NotImplementedException();
    }

    public void FindDocument()
    {
        throw new NotImplementedException();
    }

    public void MakeNewDocument()
    {
        throw new NotImplementedException();
    }
}