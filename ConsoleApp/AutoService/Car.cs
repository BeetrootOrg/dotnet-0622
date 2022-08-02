class Car : Vehicle
{
    public string Description { get; init; }
    public int OrderNumber { get; init; }
    public string[] Photo { get; init; }
    public string RegistrationPlate { get; init; }

    public override float MeasurementBrakeForce(float factor)
    {
        throw new ArgumentException("Parameter cannot be more zero.", nameof(factor));
    }

    public Car() : base(new Body(), new Engine(), new Wheel[1])
    {
        Description = "description";
        OrderNumber = 0;
        Photo = new string[] { string.Empty };
    }

    public Car(string description, int orderNumber, string[] photo, Body body, Engine engine, Wheel[] wheels) : base(body, engine, wheels)
    {
        Description = description;
        OrderNumber = orderNumber;
        Photo = photo;
    }
}