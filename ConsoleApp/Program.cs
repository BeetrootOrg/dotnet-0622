using System;
bool Compare (string str1, string str2)
{
    if (str1.Length != str2.Length)
    {
        return false;
    } 
    for (var item = 0; item < str1.Length; item++)
    {
        if (str1[item] != str2[item])
        {
            return false;
        }
        
    }
    return true;
}
(int alphabeticChars, int digits, int specChar) Analyze (string str)
{
    int charCount = 0;
    int didgitCount = 0;
    int specCount = 0;
    for (var item = 0; item < str.Length; item++)
        if (char.IsLetter(str[item]))
        {
            charCount++;
        }
        else if (char.IsNumber(str[item]))
        {
            didgitCount++;
        }
        else
        {
            specCount++;
        }
    return (charCount, didgitCount, specCount);
}
string Sort (string str)
{
    str = str.ToLower();
    var arr = str.ToCharArray();
    Array.Sort(arr);
    var str1 = string.Empty;
    str1 = string.Join("", arr);
    return str1;
}
string[] Duplicate (string str)
{
    string intermediateResult = "";
    string str1 = str.ToLower();
    for (int i = 0; i < str1.Length; i++)
    {
        char currentChar = str1[i];
        for (int j = i + 1; j < str1.Length; j++)
        {
            if (str1[j] == currentChar)
            {
                intermediateResult += currentChar;
            }
        }
    }
    var resiltString = "";
    var unique = new HashSet<char>(intermediateResult);
    foreach (char c in unique)
    {
        resiltString += c;
    }
    string[] result = null;
    Array.Resize(ref result, resiltString.Length);
    for (int i = 0; i < resiltString.Length; i++)
    {
        result[i] = new string(resiltString[i], 1);
    }
    return result;
} 