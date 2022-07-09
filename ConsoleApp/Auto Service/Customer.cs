namespace ConsoleApp.AutoService;

class Customer : Person
{
    public string Order { get; init; }
    public Vehicle VehicleToWork { get; init; }
    public int PhoneNumber { get; init;}

    public Customer(string order, Vehicle vehicleToWork, int phoneNumber)
    {
        Order = order;
        VehicleToWork = vehicleToWork;
        PhoneNumber = phoneNumber;
    }
}