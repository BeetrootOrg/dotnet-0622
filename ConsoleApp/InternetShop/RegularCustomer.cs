namespace InternetShop;

abstract class RegularCustomer : Customer
{
    public override double CalculateDeliveryPrice()
    {
        return 100;
    }
}