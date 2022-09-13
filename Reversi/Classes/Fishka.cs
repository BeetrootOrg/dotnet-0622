
public readonly struct Fishka
{
    private readonly char symb { get; init; }

    public Fishka(char symb)
    {
        this.symb = symb;
    }

    public Fishka()
    {
        this.symb = 'B';
    }

    public static implicit operator Fishka(bool val)
    {
        if (val)
        {
            return new Fishka { symb = 'W' };
        }
        return new Fishka { symb = 'B' };
    }

    public static explicit operator bool(Fishka val)
    {
        if (val.symb == 'W')
        {
            return true;
        }
        return false;
    }

    public static implicit operator Fishka(string val)
    {
        if (val == "W")
        {
            return new Fishka { symb = 'W' };
        }
        return new Fishka { symb = 'B' };
    }

    public static explicit operator string(Fishka val)
    {
        if (val.symb == 'W')
        {
            return "W";
        }
        return "B";
    }

    public static implicit operator Fishka(char val)
    {
        return new Fishka { symb = val };

    }

    public static explicit operator char(Fishka val)
    {
        return val.symb;
    }

    public override string ToString()
    {
        return (string)this;
    }

    public TypeCode GetTypeCode()
    {
        return TypeCode.Boolean + Enum.GetNames(typeof(TypeCode)).Length;
    }

    public static Fishka operator !(Fishka obj)
    {
        if (obj.symb == 'W')
        {
            return 'B';
        }
        return 'W';
    }
    // public bool ToBoolean(IFormatProvider? provider)
    // {
    //     return ((IConvertible)this).ToBoolean(provider); ;
    // }

    // public object? GetFormat(Type? formatType)
    // {
    //     return (object?) formatType;
    // }
}