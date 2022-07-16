using ConsoleApp.VoteApp;

ConsoleMenu VoteApp = new ConsoleMenu();

while (true)
{
    try
    {
        VoteApp.MainMenu();
    }
    
    catch(Exception error)
    {
        Console.Clear();
        System.Console.WriteLine(error.Message);
        Console.ReadKey();
    }
}