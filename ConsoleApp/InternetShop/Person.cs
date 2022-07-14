namespace ConsoleApp.InternetShop;

abstract class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

   virtual public void Notify( string message )
    {
      System.Console.WriteLine(message);
      
    }

}