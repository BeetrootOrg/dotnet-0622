namespace ConsoleApp;

public class Customer : Person
{
    public string DeliveryAddress {get; init;}
    public Order[] Order {get; init;}
}