internal class Program
{
    static bool Compare(string a, string b)
    {
        if (a.Length == b.Length)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    static (int, int, int) Analyze(string text)
    {
        int lettersNumber = 0;
        int digitsNumber = 0;
        int symbolsNumber = 0;
        for (int i = 0; i < text.Length; ++i)
        {
            if (char.IsLetter(text[i]))
            {
                ++lettersNumber;
            }
            else if (char.IsDigit(text[i]))
            {
                ++digitsNumber;
            }
            else if (char.IsSymbol(text[i]) || char.IsPunctuation(text[i]))
            {
                ++symbolsNumber;
            }
        }
        return (lettersNumber, digitsNumber, symbolsNumber);
    }
    static char[] BubbleSort(char[] arr)
    {
        char[] copy = new char[arr.Length];
        Array.Copy(arr, copy, arr.Length);
        char temp;
        for (int i = 0; i < copy.Length; i++)
        {
            for (int j = 0; j < copy.Length - 1; j++)
            {
                if (copy[j] > copy[j + 1])
                {
                    temp = copy[j];
                    copy[j] = copy[j + 1];
                    copy[j + 1] = temp;
                }
            }
        }
        return copy;
    }
    static string Sort(string text)
    {
        text = text.ToLower();
        char[] result1 = BubbleSort(text.ToCharArray());
        return new string(result1);
    }

    static char[] Duplicate(string text)
    {
        text = text.ToLower();
        string newText = "";
        for (int i = 0; i < text.Length; ++i)
        {
            for (int j = 0; j < text.Length; ++j)
            {
                if (char.IsLetter(text[i]) && char.IsLetter(text[j]))
                {
                    if (text[i] == text[j])
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (newText.Contains(text[i]))
                        {
                            continue;
                        }
                        newText += text[j].ToString();
                    }
                }
                else
                {
                    continue;
                }
            }
        }
        char[] result2 = newText.ToCharArray();
        return result2;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Compare("hello", "helloo"));
        (int, int, int) result1 = Analyze("A1!");
        Console.WriteLine($@"Contains 
Letters: {result1.Item1} 
Digits: {result1.Item2}
Symbols: {result1.Item3}");
        System.Console.WriteLine(Sort("Veronika"));
        System.Console.WriteLine(Sort("Tikhon"));
        System.Console.WriteLine(Duplicate("Hello humans! We came with peace"));
    }
}