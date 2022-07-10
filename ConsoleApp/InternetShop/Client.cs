namespace ConsoleApp.InternetShop;

internal class Client : Human
{
    private int _clientId { get; init; }
    private string _userName { get; init; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public IClientReceipt Receipt { get; set; }

}

interface IClientReceipt : IReceiptCreate, IReceiptClear
{
    public void ReceiptCreate();
    public void ReceiptClear();

}