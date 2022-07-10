namespace ConsoleApp.InternetShop;

internal class Receipt
{
    private int _clientId { get; init; }
    private int _receiptId { get; init; }
    public int[] ProductList { get; init; }

}

interface IReceiptCreate
{
    public void ReceiptCreate();
}
interface IReceiptClear
{
    public void ReceiptClear();
}