Console.WriteLine("Compare method:");
string str_1 = "aufwbferfu";
string str_2 = "aufwbferfu";
Console.WriteLine(Compare(str_1, str_2));
Console.WriteLine();

static bool Compare(string comp_1, string comp_2)
{
    if (comp_1.Length != comp_2.Length) return false;
    else
    {
        for (int i = 0; i < comp_1.Length; i++)
        {
            if (comp_1[i] != comp_2[i]) return false;
        }
        return true;
    }
}


Console.WriteLine("Sort method:");
string temp = "bicadw";
string res = Sort(temp);
Console.WriteLine(res);
Console.WriteLine();

static string Sort(string strToSort)
{
    char[] symbolsToSort = strToSort.ToCharArray();
    Array.Sort(symbolsToSort);
    return new string(symbolsToSort);
}


Console.WriteLine("Duplicate method:");
string test = "aaaaaaabbbbbbbjjasdnjgnnuabbz";
char[] chars = Duplicate(test);
foreach (var item in chars)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

static char[] Duplicate(string inputStr)
{
    string duplicateChars = "";
    for (int i = 0; i < inputStr.Length; i++)
    {
        if (inputStr.IndexOf(inputStr[i]) != inputStr.LastIndexOf(inputStr[i]))
        {
            duplicateChars += inputStr[i];
            while (inputStr.IndexOf(inputStr[i]) != inputStr.LastIndexOf(inputStr[i]))
            {
                inputStr = inputStr.Remove(inputStr.LastIndexOf(inputStr[i]), 1);
            }
        }
    }
    char[] dupChars = duplicateChars.ToCharArray();
    return dupChars;
}


Console.WriteLine("Analyze method:");
string result = "1ghif46sf4/>a,awe<?sad";
Tuple<int, int, int> resultTuple = Analyze(result);
Console.WriteLine(resultTuple.ToString());

static Tuple<int, int, int> Analyze(string strToAnalyze)
{
    int alphabet = 0;
    int digit = 0;
    int specialCharacters = 0;
    for (int i = 0; i < strToAnalyze.Length; i++)
    {
        if (Char.IsLetter(strToAnalyze[i]))
        {
            alphabet++;
        }
        else if (Char.IsDigit(strToAnalyze[i]))
        {
            digit++;
        }
        else
        {
            specialCharacters++;
        }
    }
    return Tuple.Create(alphabet, digit, specialCharacters);
}