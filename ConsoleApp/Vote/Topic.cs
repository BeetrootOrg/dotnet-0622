
internal class Topic
{
    private string _name;

    private long _no;

    private long _yes;

    public string Name
    {
        get
        {
            return _name;
        }
        init
        {
            if (value != null && value.Length > 0)
            {
                _name = value;
            }
            else
            {
                _name = string.Empty;
            }
        }
    }

    public long No
    {
        get
        {
            return _no;
        }
        set
        {
            if (value - _no == 1)
            {
                _no = value;
            }
        }
    }

    public long Yes
    {
        get
        {
            return _yes;
        }
        set
        {
            if (value - _yes == 1)
            {
                _yes = value;
            }
        }
    }

    internal Topic(string name)
    {
        Name = name;
        No = 0;
        Yes = 0;
    }

}