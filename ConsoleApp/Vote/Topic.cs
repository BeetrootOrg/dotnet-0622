
internal class Topic
{
    public string Name
    {
        private set
        {
            if (value != null && value.Length > 0)
            {
                Name = value;
            }
            else
            {
                Name = string.Empty;
            }
        }
        get
        {
            return Name;
        }
    }

    public long[] Choice { get; init; }


    internal Topic(string value)
    {
        Name = value;
        Choice = new long[2];
    }













}