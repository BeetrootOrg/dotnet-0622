static bool Compare(string str1, string str2)
{
    if (str1.Length != str2.Length) return false;
    else
    {
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) return false;
        }
        return true;
    }
}

static Tuple<int, int, int> Analyze(string str)
{
    int letters = 0;
    int digits = 0;
    int specChars = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (Char.IsLetter(str[i]))
        {
            letters++;
        }
        else if (Char.IsDigit(str[i]))
        {
            digits++;
        }
        else
        {
            specChars++;
        }
    }
    return Tuple.Create(letters, digits, specChars);
}

static string Sort(string str)
{
    str = str.ToLower();
    char[] sortArr = str.ToCharArray();
    Array.Sort(sortArr);
    return new string(sortArr);
}

static char[] Duplicate(string str)
{
    string duplicates = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str.IndexOf(str[i]) != str.LastIndexOf(str[i]))
        {
            duplicates += str[i];
            while (str.IndexOf(str[i]) != str.LastIndexOf(str[i]))
            {
                str = str.Remove(str.LastIndexOf(str[i]), 1);
            }
        }
    }
    char[] dubs = duplicates.ToCharArray();
    return dubs;
}

Console.WriteLine("---Compare method---");
string str1 = "ASCII";
string str2 = "ASCIl";
Console.WriteLine(Compare(str1, str2));

Console.WriteLine("---Analyze method---");
string result = "D:\\BetRoot\\dotnet-0622\\ConsoleApp>";
Tuple<int, int, int> tupleRes = Analyze(result);
Console.WriteLine(tupleRes.ToString());

Console.WriteLine("---Sort method---");
string temp = "overtime";
string sortRes = Sort(temp);
Console.WriteLine(sortRes);

Console.WriteLine("---Duplicate method---");
string dubsRes = "nochnoi ne meeeeeeeeehhhhhhhhh time";
char[] chars = Duplicate(dubsRes);
foreach (var item in chars)
Console.Write(item + " ");