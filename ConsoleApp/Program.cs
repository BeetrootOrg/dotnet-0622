// create next methods:

// Compare that will return true if 2 strings are equal, otherwise false, but do not use build-in method
// Analyze that will return (write in console) number of alphabetic chars in string, digits and another special characters
// Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')
// Duplicate that will return array of characters that are duplicated in input string (e.g. 'Hello and hi' -> ['h', 'l'])
using System.Text;

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
    {
        
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
    }
    return (charCount, didgitCount, specCount);
}

string Sort (string str)
{
    str = str.ToLower();
    var arr = str.ToCharArray();
    Array.Sort(arr);
    var str1 = string.Empty;
    for (var index = 0; index < arr.Length; index++)
    {
        str1 = string.Join("", arr);
    }
    return str1;
}

