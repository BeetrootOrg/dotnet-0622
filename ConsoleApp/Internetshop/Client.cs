namespace ConsoleApp.Internetshop;

class Client : Person
{
    private int _discountValue { get; set; }
    private string _loyalty { get; set; }
    private bool _isBlocked { get; set; }


    override public void AddNewPerson()
    {
        System.Console.WriteLine("new client added .. ");
    }
}