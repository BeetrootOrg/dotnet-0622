namespace ConsoleApp;
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weigth { get; set; }
    public byte Heigth { get; set; }

    public override string ToString()
    {
        return "FirstName = "+FirstName + " LastName = " + LastName + "Weigth = " + Weigth + "Heigth = " +  Heigth;
    }

}