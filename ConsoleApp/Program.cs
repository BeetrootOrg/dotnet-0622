var text1 = "Hello World123/.,m!";
var text2 = "Hello Danylo!";
System.Console.WriteLine(text1, text2);

var res1 = Compare(text1, text2);
System.Console.WriteLine(res1);

var res2 = Sort(text1);
System.Console.WriteLine(res2);

var res3 = Analyze(text1);
System.Console.WriteLine($"Digit: {res3.Item1} Letter: {res3.Item2} Number: {res3.Item3}");

var text3 = "Hello World!";
var text4 = "Hello Danylo!";
var resault =  Duplicate(text3, text4);
System.Console.WriteLine($"Duplicate characters: {resault}");


bool Compare(string t1, string t2)
{
    for (int i = 0; i < t1.Length; i++)
    {
        if (t1[i] != t2[i]) return false;
    }
    return true;
};

string Sort(string t1)
{
    var arrChar = t1.ToCharArray();
    Array.Sort(arrChar);
    string sortArr = new string(arrChar);
    return sortArr;
};

(int, int, int) Analyze(string t1)
{
    int d = 0, l = 0, n = 0;
    var arrChar = t1.ToCharArray();
    foreach (var item in arrChar)
    {
        if (char.IsDigit(item)) d++;

        if (char.IsLetter(item)) l++;

        if (char.IsNumber(item)) n++;
    }
    return (d, l, n);
}

char[] Duplicate(string t1, string t2)
{
    char[] duplicateCharacters = new char[50];

    var arrChar1 = t1.ToCharArray();
    var arrChar2 = t2.ToCharArray();

    for (int i = 0; i < t1.Length; i++)
    {
        for (int j = 0; j < t2.Length; j++)
        {
            if (arrChar1[i] == arrChar2[j])
            {
                duplicateCharacters[i] = arrChar2[j];
            }
        }
    }
    return duplicateCharacters;
}