using static System.Console;

public class ConsoleInterface
{
    private Vote Vote { get; set; }


    public void MainMenu()
    {
        //doit = true;
        Clear();
        WriteLine("Welcome to phone book!");
        WriteLine();
        WriteLine("Menu:");
        WriteLine("1.Create Vote");
        WriteLine("2.Vote for something");
        WriteLine("3.Show results");
        WriteLine("0.Exit");

        var key = ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.D0:
                {
                    //doit = false;
                    Exit();
                    break;
                }
            case ConsoleKey.D1:
                {
                    //Vote();
                    break;
                }
            case ConsoleKey.D2:
                {
                    break;
                }
            case ConsoleKey.D3:
                {
                    //ShowResults();
                    break;
                }
            default:
                {
                    //doit = false;
                    break;
                }
        }
        //return doit;
    }

    static void Exit()
    {
        //doit = false;
        Environment.Exit(0);
    }

    public void Create()
    {
        Vote.Topics.Add(new Topic("sdfsdf"));
    }

    public void Show()
    {
        Clear();
        Clear();
        WriteLine($"{action}");
        WriteLine();
        if (Vote.Topics.Count > 0)
        {
            ShowRow(("FirstName", "LastName", "Phone"));
            foreach (var topic in Vote.Topics)
            {
                ShowRow(topic.Name);
            }
            WriteLine("Press any key to continue...");
            ReadKey();
        }
        else
        {
            //Show("Search for a contact in the phone book.", "The contact not found.");
            WriteLine();
        }
    }
    static void ShowRow((string, string, string) row)
    {
        var (FirstName, LastName, Phone) = row;
        WriteLine("{0,-15} {1,-15} {2,-15}", FirstName, LastName, Phone);
    }

    internal ConsoleInterface(ref Vote vote)
    {
        Vote = vote;
    }
}