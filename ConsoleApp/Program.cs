using ConsoleApp.Vote;

VoteList dataBase = new VoteList();


Menu();

void DrawMenuOptions()
{
    Console.Clear();
    Console.WriteLine("1: Create Vote");
    Console.WriteLine("2: Vote for something");
    Console.WriteLine("3: Show Results");
    Console.WriteLine("0: Exit");
}

void Menu()
{
    while (true)
    {
        DrawMenuOptions();

        var option = Console.ReadKey();

        switch (option.Key)
        {

            //Create Vote
            case ConsoleKey.D1:
                {
                    CreateVote();
                    break;
                }
            //Vote for something
            case ConsoleKey.D2:
                {
                    VoteForSomething();
                    break;
                }
            //Show Results
            case ConsoleKey.D3:
                {
                    ShowResults();
                    break;
                }
            //Show the Tables we have
            case ConsoleKey.D0:
                {
                    
                   return;
                }

        }
    }
}

void CreateVote()
{
    Console.Clear();
    Console.WriteLine("Input Vote Topic: ");
    var voteTopic = Console.ReadLine();

    if (!dataBase.CreateVoteTopic(voteTopic.ToLower())) return;

    string message = "Topic is Created!";
    message.PressAnyKeyToProcced();
}

void VoteForSomething()
{
    Console.Clear();
    Console.WriteLine("Input Vote Topic: ");
    var voteTopic = Console.ReadLine();


    Console.WriteLine("Vote Variants for YES: yes , yeah , yah , y , 1 , ok ");
    Console.WriteLine("Vote Variants for NO: no , nah , n , 0");

    Console.WriteLine("Write your vote answer: ");
    var voteAnswer = Console.ReadLine();

    if (!dataBase.ToVote(voteTopic.ToLower(), voteAnswer.ToLower())) return;

    string message = "Your Vote saved!";
    message.PressAnyKeyToProcced();

}

void ShowResults()
{
    Console.Clear();
    Console.WriteLine("Input Vote Topic: ");
    var voteTopic = Console.ReadLine();
    
    Console.WriteLine($"-- {voteTopic} --");

    dataBase.Show(voteTopic.ToLower());

    string message = "";
    message.PressAnyKeyToProcced();

}


