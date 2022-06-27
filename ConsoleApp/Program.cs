using System;

using static System.Console;

bool Compare(string val1, string val2)
{
    if (val1 == null && val2 == null)
    {
        return true;
    }

    // val1?.Length -> val1 != null ? val1.Length : null
    if (val1?.Length != val2?.Length)
    {
        return false;
    }

    for (var i = 0; i < val1.Length; ++i)
    {
        if (val1[i] != val2[i])
        {
            return false;
        }
    }

    return true;
}

(int, int, int) Analyze(string value)
{
    var result = (0, 0, 0);
    foreach (var symbol in value)
    {
        if (char.IsLetter(symbol))
        {
            ++result.Item1;
        }
        else if (char.IsDigit(symbol))
        {
            ++result.Item2;
        }
        else if (char.IsSymbol(symbol))
        {
            ++result.Item3;
        }
    }

    return result;
}

string Sort(string value)
{
    var chars = value.ToLower().ToCharArray();
    Array.Sort(chars);
    return new string(chars);
}

char[] Duplicate(string value)
{
    var duplicates = new char[value.Length / 2];
    var index = 0;

    foreach (var symbol in value.ToLower())
    {
        if (char.IsWhiteSpace(symbol))
        {
            continue;
        }

        if (value.IndexOf(symbol) != value.LastIndexOf(symbol))
        {
            var alreadyAdded = false;
            for (var i = 0; i < index; ++i)
            {
                if (duplicates[i] == symbol)
                {
                    alreadyAdded = true;
                    break;
                }
            }

            if (!alreadyAdded)
            {
                duplicates[index++] = symbol;
            }
        }
    }

    Array.Resize(ref duplicates, index);
    return duplicates;
}

WriteLine(Compare("hell", "hello"));
WriteLine(Compare("hell", "hello"));
WriteLine(Analyze("hell"));
WriteLine(Sort("hell"));
WriteLine(Duplicate("Hello, World"));