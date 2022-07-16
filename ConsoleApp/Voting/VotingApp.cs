using System.Text.RegularExpressions;

namespace ConsoleApp.Voting;

class VotingApp
{
    private int numberOfPolls;
    public Dictionary<int, Poll> ListOfPolls { get; set; }

    public VotingApp()
    {
        ListOfPolls = new Dictionary<int, Poll>();
    }

    public void RegisterNewPoll()
    {
        Console.Clear();
        System.Console.WriteLine("Enter Topic Name");
        string topicName = Console.ReadLine();
        ValidateNotEmpty(topicName);
        System.Console.WriteLine("Enter comma-separated options");
        string options = Console.ReadLine();
        ValidateNotEmpty(options);
        List<string> listOfOptionsStr = options.Split(",").ToList<string>();

        Dictionary<int, Option> listOfOptions = new Dictionary<int, Option>();
        for (int i = 0; i < listOfOptionsStr.Count; i++)
        {
            listOfOptions.Add(i + 1, new Option(listOfOptionsStr[i]));
        }

        Poll pollToAdd = new Poll(topicName, listOfOptions);
        ListOfPolls.Add(++numberOfPolls, pollToAdd);
        MakeDelay();
    }

    public void VoteFor()
    {
        Poll chosenPoll = ChoosePoll();
        System.Console.WriteLine("Select Option");

        foreach (var item in chosenPoll.ListOfOptions)
        {
            System.Console.WriteLine($"\t{item.Key}. {item.Value.OptionName}");
        }

        ConsoleKeyInfo key = Console.ReadKey();
        int userChoise = int.Parse(key.KeyChar.ToString());
        if (chosenPoll.ListOfOptions.ContainsKey(userChoise))
        {
            chosenPoll.ListOfOptions[userChoise].IncreaseCount();
        }
        else
        {
            throw new ArgumentException("No Such Option!");
        }
        Console.Clear();
        System.Console.WriteLine("Thanks For Vote!");
        MakeDelay();
    }

    public void ShowResults()
    {
        Poll chosenPoll = ChoosePoll();
        foreach (var item in chosenPoll.ListOfOptions)
        {
            System.Console.WriteLine($"{item.Value.OptionName} - {item.Value.Count}");
        }
        MakeDelay();
    }

    private Poll ChoosePoll()
    {
        ValidatePollNumber();
        Console.Clear();
        System.Console.WriteLine("Choose Topic");
        foreach (var item in ListOfPolls)
        {
            System.Console.WriteLine($"\t{item.Key}. {item.Value.Topic}");
        }
        ConsoleKeyInfo key = Console.ReadKey();
        int userChoise = int.Parse(key.KeyChar.ToString());
        Poll chosenPoll = new Poll();
        if (ListOfPolls.ContainsKey(userChoise))
        {
            chosenPoll = ListOfPolls[userChoise];
        }
        else
        {
            throw new ArgumentException("No Such Option!");
        }
        Console.Clear();
        return chosenPoll;
    }
    private void MakeDelay()
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    private void ValidatePollNumber()
    {
        if (ListOfPolls.Count == 0)
        {
            throw new ArgumentException("No Polls Yet. Create Some Before Voting!");
        }
    }
    private void ValidateNotEmpty(string str)
    {
        throw new ArgumentException("Invalid Input!");
    }
}