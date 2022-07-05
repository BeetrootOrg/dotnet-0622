namespace ConsoleApp;

public class Order
{
    public Product[] Product {get; init;}
    public DateTime OrderDate {get; init;}
    public string Status {get; init;}
    public Customer Customer {get; init;}
}