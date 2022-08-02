internal class Program
{
    private static void Main(string[] args)
    {

        Car Samsung = new Car()
        {
            Body = new Body()
            {
                Color = "Сірий",
                Height = 1475,
                Length = 4945,
                Material = "Алюміній",
                TrunkVolume = 450,
                Type = "Седан",
                Width = 1790
            },
            Brand = "Samsung",
            CarInsurance = "\"ОРАНТА\" №1023456789 от 2005",
            Category = string.Empty,
            Description = "Має гарний стан.",
            Engine = new Engine()
            {
                Capacity = 3.5f,
                Configuration = "V-образный",
                CylinderDiameter = 95.5f,
                IntakeType = "Инжектор",
                MaxTorque = 314,
                NumberOfCylinders = 6,
                NumberOfValves = 4,
                PistonStroke = 81.4f,
                Power = 218,
                Type = "Бензиновый"
            },
            FuelTankVolume = 0,
            Model = string.Empty,
            OrderNumber = 1405020822,
            Owner = string.Empty,
            Photo = new string[] { "\\samsung_sm7.jpg" },
            RegistrationPlate = "UAАН1234АА",
            VIN = "1ABCD23EFGH456789",
            Wheels = new Wheel[] { new Wheel(new Disk(), new Tire()) },
            Year = 2005
        };
        string aboutcar ="";


    }
}