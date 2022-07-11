using ConsoleApp;
using System.Linq;
List<Vote> votes = new List<Vote>();

while (true)
{
    Menu();
}

void Menu ()
{
    Console.Clear();
    Console.WriteLine("Welcome to Vote program!");
    Console.WriteLine();
    Console.WriteLine("\t1 - Create Vote");
    Console.WriteLine("\t2 - Vote for something");
    Console.WriteLine("\t3 - Show Results");
    Console.WriteLine("\t0 - Exit");

    var keyEntered = Console.ReadKey();
    switch (keyEntered.Key)
    {
        case ConsoleKey.D1:
        CreateVote();
        break;
        case ConsoleKey.D2:
        VoteForSomething();
        break;
        case ConsoleKey.D3:
        Print(votes);
        Console.WriteLine("Press key to continue...");
        Console.ReadKey();
        break;
        case ConsoleKey.D0:
        Environment.Exit(0);
        break;
        default:
        break;
    }
}

void VoteForSomething()
{
    Console.Clear();
    if (votes.Count == 0)
    {
        Console.WriteLine("Nothing to vote for, try creating the vote first");
        Console.ReadKey();
        return;
    }

    int tempCounter = 1;

    foreach (var vote in votes)
    {
        Console.WriteLine($"{tempCounter}. {vote.Subject}");
        ++tempCounter;
    }
    tempCounter = 1;
    
    Console.WriteLine("Please select the subject you are voting for...");
    var selectedSubject = Int32.Parse(Console.ReadLine());
    if (selectedSubject < 0)
    {
        throw new ArgumentException();
    }

    Console.Clear();
    Console.WriteLine($"You have selected: \n {votes[selectedSubject - 1]}");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

    Console.Clear();
    Console.WriteLine("Please select the option you would like to vote for...");
    string[] temp = votes[selectedSubject-1].Options;
    int tempCounter1 = 1;
    for (var index = 0; index < temp.Length; index++)
    {
        Console.WriteLine($"{tempCounter1}. {temp[index]}");
        ++tempCounter1;
    }
    tempCounter1 = 1;

    int selectedOption = Int32.Parse(Console.ReadLine());

    if (selectedOption < 0 || selectedOption > temp.Length)
    {
        throw new ArgumentException();
    }
    
    votes[selectedSubject-1].AddVote(votes[selectedSubject-1], selectedOption - 1);
    Console.WriteLine("Your vote was sucessfully added!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

}

void CreateVote()
{
    Console.Clear();
    Console.WriteLine("Please enter vote Name:");
    string a = Console.ReadLine();
    if (String.IsNullOrEmpty(a))
    {
        throw new ArgumentException();
    }
    Console.Clear();
    Console.WriteLine("Please enter comma-separated vote options:");
    string b = Console.ReadLine();
    if (String.IsNullOrEmpty(a))
    {
        throw new ArgumentException();
    }
    string[] bArray = b.Split(',');
    int[] c = new int[bArray.Length];
    Console.Clear();
    Console.WriteLine("Your vote is sucessfully created!");

    votes.Add(new Vote
    {
        Subject = a,
        Options = bArray,
        VotesForOptions = c
    });
}

void Print<T>(IEnumerable<T> collection)
{
    Console.Clear();
    Console.WriteLine(string.Join("\n", collection));
}