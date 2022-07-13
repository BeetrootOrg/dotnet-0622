namespace ConsoleApp.Internetshop;
using static System.Console;

class Client : Person
{

    const string filenameClient = "dataclient.csv";
    private int _discountValue { get; set; }
    private string _loyalty { get; set; }
    private bool _isBlocked { get; set; }


    override public void AddNewPerson()
    {
        

        _discountValue = 1;
        _isBlocked = false;

        WriteLine("Set Firstname");
        Firstname = ReadLine();
        WriteLine("Set Lastname");
        Lastname = ReadLine();
        WriteLine("Set Price");
        string Serialize((string Firstname, string Lastname) row) => $"{row.Firstname},{row.Lastname}";
        File.AppendAllLines(filenameClient, new[] { Serialize((Firstname, Lastname)) });
        WriteLine("new client added .. ");
    }
}