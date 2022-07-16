namespace ConsoleApp.Voting;

class Option
{
    public string OptionName { get; init; }
    public int Count { get; private set; }

    public Option(string optionName)
    {
        OptionName = optionName;
    }

    public void IncreaseCount()
    {
        ++Count;
    }
}