internal class Program
{
    static bool Compare (string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) return false;
        }
        
        return true;        
    }

    static Tuple<int, int, int> Analyze (string str)
    {
        int letters = 0;
        int numbers = 0;
        int other = 0;
        foreach (var item in str)
        {
            if (char.IsLetter(item)) letters++;
            else if (char.IsNumber(item)) numbers++;
            else other++;
        }
    return Tuple.Create(letters, numbers, other);     
    }

    static string Sort(string str)
    {
        str = str.ToLower();
        var strArray = str.ToCharArray();
        Array.Sort(strArray);
        return new String(strArray);
    }

    static char[] Duplicate (string str)
    {
        string dubs = "";
        str = str.ToLower();
        string strSub = "";
        
        for (int i = 0; i < str.Length; i++)
        {   
            strSub = str.Substring(i+1);
        
            if (strSub.Contains(str[i]) && !dubs.Contains(str[i]))
            {
                if (str[i] != ' ') dubs += str[i];
            } 
        }
        
        return dubs.ToCharArray();
    }
                   
    static void Main(string[] args)
    {
        string string1 ="SOme 123 excelledt 4567 string here!";
        string string2 ="SOme 123 excelledt 45 string here!!!";
        Console.WriteLine(Compare (string1, string2));
        
        var analyzeRes = Analyze(string1);
        
        Console.WriteLine($"String [{string1}] contains:");
        Console.WriteLine($"Letters: {analyzeRes.Item1}");
        Console.WriteLine($"Digits: {analyzeRes.Item2}");
        Console.WriteLine($"Spaces and other: {analyzeRes.Item3}");

        Console.WriteLine(Sort("Hello"));

        foreach (var item in Duplicate("Hello and hi o"))
        {
            Console.WriteLine (item);
        }

    }    
      
}