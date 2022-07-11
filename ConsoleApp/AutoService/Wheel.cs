class Wheel : Detail
{
    public string Wheels { get; set; }
    public decimal WheelsPrice { get; set; }
    public int WheelsAmount { get; set; }
    public Wheel(string wheels, decimal wheelsPrice, int wheelsAmount ) : base(wheels, wheelsPrice, wheelsAmount)
    {
        Wheels = wheels;
        WheelsPrice = wheelsPrice;
        WheelsAmount = wheelsAmount;
    }
}