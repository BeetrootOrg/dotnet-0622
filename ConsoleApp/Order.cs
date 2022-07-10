namespace Shop;

internal class Order
{
    private string _name { get; init; }
    private int _recNumber { get; init; }
    public string[] Products { get; init; }
}

interface INewReceipt
{
    public void NewReceipt();
}
interface IClearReceipt
{
    public void ClearReceipt();
}