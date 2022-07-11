class Vehicle
{
    public Wheel VehicleWheels { get; set; }
    public Engine VehicleEngige { get; set; }
    public List<string> AdditionalDetails { get; set; }
    public decimal VehiclePrice { get; set; }
    public int VehicleCapacity { get; set; }
    public Vehicle(Wheel vehicleWheels, Engine vehicleEngige, List<string> additionalDetails, decimal vehiclePrice, int vehicleCapacity)
    {
        VehicleWheels = vehicleWheels;
        VehicleEngige = vehicleEngige;
        AdditionalDetails = additionalDetails;
        VehiclePrice = vehiclePrice;
        VehicleCapacity = vehicleCapacity;
    }

}