using static System.Console;
void Exit()
{
    Environment.Exit(0);
}

void ShowAll()
{
    Clear();
    var contacts = new[]
    {
        ("First", "Last", "+3801234567"),
        ("f", "L", "+380123578"),
    };
    WriteLine("{0,-15} {1,-15} {2,-15}", "First Name", "Last Name", "Phone");
    foreach (var (firstName, lastName, phone) in contacts)
    {
        WriteLine("{0,-15} {1,-15} {2,-15}", firstName, lastName, phone);
        
    }
    WriteLine("Press eny kay to continue...");
    ReadKey();
}

void MainMenu()
{
    Clear();

    Console.WriteLine("Welcome to phone book!");
    Console.WriteLine();
    WriteLine("Menu:");
    WriteLine("\t1 - Show all contacts");
    WriteLine("\t2 - Add new contact");
    WriteLine("\t3 - Update contact");
    WriteLine("\t4 - Remove contact");
    WriteLine("\t0 - Exit");

    var key = ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D0:
            Exit();
            break;
        case ConsoleKey.D1:
            ShowAll();
            break;
        default:
            MainMenu();
            break;

    }
}
while (true)
{
MainMenu();
}

