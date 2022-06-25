using System;
class Program
{
    static bool Compare(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        for (int i = 0; i < str1.Length; ++i)
        {
            if (str1[i] != str2[i])
                return false;
        }
        return true;
    }
    static void Analyze(string text, out int charnumb, out int digitnumb, out int speccharnumb)
    {
        charnumb = 0;
        digitnumb = 0;
        speccharnumb = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                charnumb++;
            }
            if (char.IsDigit(text[i]))
            {
                digitnumb++;
            }
            if (char.IsSymbol(text[i]))
            {
                speccharnumb++;
            }

        }
    }
    static string SortStrMethod(string texttosort)
    {
        string tolower = texttosort.ToLower();
        var arr = texttosort.ToCharArray();
        Array.Sort(arr);
        string sorted = new string(arr);
        return sorted;
    }

    static char[] Duplicate(string inputstr)
    {
        string duplicatedstr = new string("");
        for (int i = 0; i < inputstr.Length; i++)
        {
            for (int j = i + 1; j < inputstr.Length; j++)
            {
                if (inputstr[j] == inputstr[i] && !duplicatedstr.Contains(inputstr[j]))
                {
                    duplicatedstr += inputstr[j];
                }
            }
        }
        return duplicatedstr.ToCharArray();

    }
    static void Main()
    {
        string str1 = "hello!";
        string str2 = "goodbye!";
        Console.WriteLine(Compare(str1, str2));

        string text = "Some kind of text with special characters+$ and digits77";
        Analyze(text, out int chnumb, out int dignumb, out int spnumb);
        System.Console.WriteLine($"The number of characters is {chnumb}");
        System.Console.WriteLine($"The number of digits is {dignumb} ");
        System.Console.WriteLine($"The number of specialchar is {spnumb}");

        string stringtosort = new string("anything");
        string sortedstring = SortStrMethod(stringtosort);
        System.Console.WriteLine(sortedstring);

        string strwithduplicates = new string("cat lullaby");
        char[] duplicatesarray = Duplicate(strwithduplicates);
        System.Console.WriteLine(duplicatesarray);
    }

}
