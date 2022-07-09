namespace ConsoleApp;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; }
    public byte Height { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(FirstName)}: {FirstName}, " +
            $"{nameof(LastName)}: {LastName}, " +
            $"{nameof(Weight)}: {Weight}, " +
            $"{nameof(Height)}: {Height}}}";
    }
}