namespace InternetShop;

abstract class Customer
{
    protected string Name {get; set;}
    protected string Address {get; set;}
    protected string PhoneNumber {get; set;}
    protected string Email {get; set;}
    public abstract double CalculateDeliveryPrice();
}