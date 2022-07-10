namespace Shop;

internal class Customer : Person
{
    private string _name { get; init; }
    private string _mail { get; set; }
    protected string HomeAdress { get; set; }

}

interface ICustomerOrderReceipt : INewReceipt, IClearReceipt
{
    public void NewReceipt();
    public void ClearReceipt();
}