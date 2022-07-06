namespace InternetShop;

abstract class PrimeCustomer : Customer
{
    public override double CalculateDeliveryPrice()
    {
        return 0;
    }
}