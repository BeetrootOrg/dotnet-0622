/*create next methods:

    Compare that will return true if 2 strings are equal, otherwise false, but do not use build-in method
    Analyze that will return number of alphabetic chars in string, digits and another special characters
    Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')
    Duplicate that will return array of characters that are duplicated in input string (e.g. 'Hello and hi' -> ['h', 'l'])
*/

//using System.Text;
string testText1 = "pnMvm21sse9812G";
string testText2 = "pnMvm23sse9812G";
string testText3 = "pnsdf345*))2,23sse9812G";
string testText4 = "pnszAfvceYdlG";
string testText5 = "pnszAaygfvceYdlG";

int thisIsChar = 0;
int thisIsDigic = 0;
int thisIsSpS = 0;
var resstring = "";


System.Console.WriteLine("------------------ COMPARE ---");
static bool CompareMeth(string param1, string param2)
{
    if (param1.Length != param2.Length)
    {
        return false;
    }
    else
    {
        for (int i = 0; i < param1.Length; i++)
        {
            if (param1[i] != param2[i])
            {
                return false;
            }
        }
    }
    return true;
}
System.Console.WriteLine(CompareMeth(testText1, testText2));



System.Console.WriteLine("------------------- Analyze ---");
static bool AnalyzeStringMeth(string TextForAnalyze, out int leter, out int digi, out int symb)
{
    leter = 0;
    digi = 0;
    symb = 0;

    for (int i = 0; i < TextForAnalyze.Length; ++i)
    {
        if (char.IsDigit(TextForAnalyze[i]))
        {
            digi = digi + 1;
        }
        else if (char.IsLetter(TextForAnalyze[i]))
        {
            leter = leter + 1;
        }
        else
        {
            symb = symb + 1;
        }
    }
    return true;
}
AnalyzeStringMeth(testText3, out thisIsChar, out thisIsDigic, out thisIsSpS);
System.Console.WriteLine("Char= " + thisIsChar + " : Digic= " + thisIsDigic + " : Symbols =" + thisIsSpS);



System.Console.WriteLine("------------------- SORTE ---");
static void SortString(string testText4)
{
    string lowerForm = testText4.ToLower();
    var arr = lowerForm.ToCharArray();
    Array.Sort(arr);

    var allSymbolsBuilder = new System.Text.StringBuilder();
    foreach (var item in arr)
    {
        allSymbolsBuilder.Append(item);
    }
    System.Console.WriteLine(allSymbolsBuilder);
}
SortString(testText4);



System.Console.WriteLine("------------------ Duplicate ---");
if (testText5.Length > 0)
{
    string lowerForm1 = testText5.ToLower();
    for (int i = 0; i < lowerForm1.Length; ++i)
    {
        var symbProgres = lowerForm1[i];
        int findCount = 0;

        for (int p = 0; p < lowerForm1.Length; p++)
        {
            if (symbProgres == lowerForm1[p])
            {
                findCount = findCount + 1;
            }
        }
        if (findCount >= 2)
        {
            if (!resstring.Contains(symbProgres))
            {
                resstring = resstring + symbProgres;
            }
        }
    }
}
if (resstring.Length > 0)
{
    var arreyDublicate = resstring.ToCharArray();
    System.Console.WriteLine("---  " + resstring);
}

