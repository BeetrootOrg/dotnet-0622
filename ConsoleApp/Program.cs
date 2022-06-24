struct StringAnalyzer
{
    public int numberOfLetters;
    public int numberOfDigits;
    public int numberOfCharacters;
}
internal class Program
{
    static char[] SelectionSort(char[] arr)
    {
        char[] copyArr = new char[arr.Length];
        Array.Copy(arr, copyArr, arr.Length);

        for (int i = 0; i < copyArr.Length - 1; i++)
        {
            var smallestNumberIndex = i;

            for (int j = i + 1; j < copyArr.Length; j++)
            {
                if (copyArr[j] < copyArr[smallestNumberIndex])
                {
                    smallestNumberIndex = j;
                }
            }

            var temp = copyArr[smallestNumberIndex];
            copyArr[smallestNumberIndex] = copyArr[i];
            copyArr[i] = temp;
        }
        return copyArr;
    }
    static bool Compare(string firstStr, string secondStr)
    {
        if (firstStr.Length != secondStr.Length)
        {
            return false;
        }

        for (int i = 0; i < firstStr.Length; i++)
        {
            if (firstStr[i] != secondStr[i])
            {
                return false;
            }
        }

        return true;
    }
    static StringAnalyzer? Analyze(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return null;
        }
        StringAnalyzer analyzer = new StringAnalyzer();

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsLetter(str[i]))
            {
                analyzer.numberOfLetters++;
            }
            if (Char.IsDigit(str[i]))
            {
                analyzer.numberOfDigits++;
            }
            if (Char.IsSymbol(str[i]))
            {
                analyzer.numberOfCharacters++;
            }
        }

        return analyzer;
    }

    static string Sort(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return null;
        }

        return new string(SelectionSort(str.ToLower().ToCharArray()));
    }

    static char[] Duplicate(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return null;
        }

        str = str.ToLower();
        string stringToReturn = String.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j] && !stringToReturn.Contains(str[i]) && Char.IsLetter(str[i]))
                {
                    stringToReturn += str[i];
                }
            }
        }

        if (String.IsNullOrEmpty(stringToReturn))
        {
            return Array.Empty<char>();
        }

        return stringToReturn.ToCharArray();
    }
    private static void Main(string[] args)
    {
        //Compare
        System.Console.WriteLine(Compare("Hello", "Hello"));
        System.Console.WriteLine(Compare("Hello", "hello"));
        System.Console.WriteLine(Compare("1234", "1234 "));
        System.Console.WriteLine(Compare("Yes", "No"));

        //Analyze
        string testStringToAnalyze = "|T3st str1ng 2 analyz3|";
        StringAnalyzer? analyzer = Analyze(testStringToAnalyze);
        if (analyzer is not null)
        {
            System.Console.WriteLine("\nTest string has:");
            System.Console.WriteLine($"\t{analyzer.Value.numberOfLetters} letters");
            System.Console.WriteLine($"\t{analyzer.Value.numberOfDigits} digits");
            System.Console.WriteLine($"\t{analyzer.Value.numberOfCharacters} characters");
        }

        //Sort
        System.Console.WriteLine($"\n{Sort("Gello")}");
        System.Console.WriteLine(Sort("Xenotransplantation"));
        System.Console.WriteLine(Sort("Pulchritudinous"));
        System.Console.WriteLine($"{Sort("Psychotomimetic")}\n");

        //Duplicate 
        char[] myCharArray = Duplicate("Arigato gozaimasu!");
        foreach (var item in myCharArray)
        {
            Console.Write(item + " ");
        }
    }
}