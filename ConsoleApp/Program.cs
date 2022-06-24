class Program
{
    static bool Compare(string str1, string str2)
    {
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) return false;
        }
        return true;
    }

    static Tuple<int, int, int> Analyze(string str)
    {
        int letter = 0, number = 0, specSymbol = 0;
        for (var i = 0; i < str.Length; i++)
            if (char.IsLetter(str[i])) letter++;
            else if (char.IsNumber(str[i])) number++;
            else specSymbol++;
        return Tuple.Create(letter, number, specSymbol);
    }

    static string Sort(string str)
    {
        str = str.ToLower();
        var arr = str.ToCharArray();
        Array.Sort(arr);
        string sort = new string(arr);
        return sort;
    }
 
    static string Duplicate(string str)
    {
        string dupStr = "";
        str = str.ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i+1; j < str.Length; j++)
            {
                if(str[i] == str[j]) dupStr += str[i];
            }
        }
        return dupStr;
    }

    static void Main()
    {
        string str1 = "string3@% >//";
        string str2 = "String";
        Console.WriteLine(Compare(str1, str2));
        Console.WriteLine(Analyze(str1));
        Console.WriteLine(Sort("Hello"));
        Console.WriteLine(Duplicate("Hello and hi"));
    }
}
