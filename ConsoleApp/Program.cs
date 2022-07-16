using ConsoleApp.Voting;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        MainMenu menu = new MainMenu();
        while (true)
        {
            try
            {
                menu.MainMenuInterface();
            }
            catch (ArgumentException ae)
            {
                ShowException(ae);
            }
            catch (FormatException fe)
            {
                ShowException(fe);
            }
        }
    }
    static void ShowException(Exception e)
    {
        Console.Clear();
        System.Console.WriteLine(e.Message);
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}