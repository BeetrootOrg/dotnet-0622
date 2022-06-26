static bool StringCompare(string str1, string str2)
{   

    if(str1.Length != str2.Length) 
    {
        return false;
    }
    
    for(int i = 0 ; i< str1.Length; ++i)
    {
        if(str1[i] != str2[i]) return false;
    }

    return true;
}
static (int,int,int)StringAnalyze(string str)
{
    int digits = 0, alphabetic = 0, other = 0;
    foreach (char i in str)
    {
        if (char.IsDigit(i))
        {
            digits += 1;
            continue;
        }
        if (char.IsLetter(i))
        {
            alphabetic += 1;
            continue;
        }
        if(char.IsSymbol(i) || char.IsPunctuation(i))
        {
            other++;
        }
    }

return (digits,alphabetic,other);

}

static string StringSort(string str)
{
    str.ToLower();

    char[] characters = str.ToCharArray();

    Array.Sort(characters);

    return new string(characters);

}

static char[] StringDuplicate(string str1, string str2)
{

    string result = "";

    string boof = str1;

    int length = str1.Length;

    while (length > 0)
    {
        char c = boof[0];
        boof = boof.Remove(0, 1);
        length--;
        if (boof.Contains(c))
        {
            if (result.Contains(c)) continue;
            result += c.ToString();
        }
        if (str2.Contains(c))
        {
            if (result.Contains(c)) continue;
            result += c.ToString();
        }
    }

    boof = str2;

    length = str2.Length;

    while (length > 0)
    {
        char c = boof[0];
        boof = boof.Remove(0, 1);
        length--;
        if (boof.Contains(c))
        {
            if (result.Contains(c)) continue;
            result += c.ToString();
        }
    }

    char[] characters = result.ToCharArray();

    return characters;
}


string str1 = "ABCD,;/$%";
string str2 = "ABBAKK";
string str3 = "ABBAKK";
Console.WriteLine(StringCompare(str2, str3));




System.Console.WriteLine(StringDuplicate(str1, str2));
System.Console.WriteLine($"Digits; Alphabetic; Other;\n{StringAnalyze(str1)}");
System.Console.WriteLine(StringCompare(str1,str2));
System.Console.WriteLine(StringCompare(str1,str1));