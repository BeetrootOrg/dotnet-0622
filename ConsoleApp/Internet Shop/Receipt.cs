namespace ConsoleApp.InternetShop;

class Receipt
{
    public Employee Cashier { get; set; }
    public Customer Buyer { get; set; }
    public Product[] SoldProducts { get; set; }
    public DateTime DateOfPurchase { get; init; }
    public int SumOfPurchase { get; init; }
}