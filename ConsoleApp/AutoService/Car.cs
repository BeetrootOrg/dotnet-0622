namespace ConsoleApp.AutoSrvice;
class Car
{
    public int RegistrationNumber { get; set; }
    public int Year { get; set; }

    public virtual void CarSound()
    {
        System.Console.WriteLine("placeholder");
    }

}