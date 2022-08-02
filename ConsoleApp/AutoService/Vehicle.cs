class Vehicle
{
    public Body Body { get; init; }
    public string Brand { get; init; }
    /// <summary>
    /// Автострахування.
    /// </summary>
    /// <value></value>
    public string CarInsurance { get; init; }
    public string Category { get; init; }
    public Engine Engine { get; init; }
    /// <summary>
    /// Об'єм паливного бака.
    /// </summary>
    /// <value></value>
    public int FuelTankVolume { get; init; }
    public string Model { get; init; }
    /// <summary>
    /// Власник.
    /// </summary>
    /// <value></value>
    public string Owner { get; init; }
    /// <summary>
    /// Vehicle Identification Number - Ідентифікаційний номер транспортного засобу
    /// </summary>
    /// <value></value>
    public string VIN { get; init; }
    public Wheel[] Wheels { get; init; }
    public int Year { get; init; }

    public virtual float MeasurementBrakeForce(float factor)
    {
        throw new ArgumentException("Parameter cannot be null", nameof(factor));
    }

    internal Vehicle(Body body, Engine engine, Wheel[] wheels)
    {
        Body = body;
        Brand = string.Empty;
        CarInsurance = string.Empty;
        Category = string.Empty;
        Engine = engine;
        FuelTankVolume = 0;
        Model = string.Empty;
        Owner = string.Empty;
        VIN = string.Empty;
        Wheels = wheels;
        Year = DateTime.Now.Year;
    }
}