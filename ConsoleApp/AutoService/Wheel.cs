class Wheel
{
    public Disk Disk { get; init; }
    public Tire Tire { get; init; }

    internal Wheel(Disk disk, Tire tire)
    {
        Disk = disk;
        Tire = tire;
    }
}