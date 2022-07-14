
namespace ConsoleApp.InternetShop;
class Buyer : Person

{
    public int PersonalID { get; init; }
    public int PhoneNumber { get; init; }
    public string Email { get; init; }

    public override void Notify(string message)
    {
        System.Console.WriteLine($"Dear Customer {message}");
    }

}




