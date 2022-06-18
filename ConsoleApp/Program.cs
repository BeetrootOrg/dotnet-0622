internal class Program
{
    static bool Compare(string a, string b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i<a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }

    static (int, int, int) Analyze(string str)
    {        
        if (str.Length == 0) return (0,0,0);
        (int, int, int) result = (0,0,0);
        for (int i=0; i<str.Length; i++)
            if (Char.IsLetter(str[i])) result.Item1++;
            else if (Char.IsDigit(str[i])) result.Item2++;
            else result.Item3++;
        return result;
    }

    static string Sort(string str)
    {
        string result = str.ToLower();
        for (int i=0; i<result.Length; i++)
            for (int j=0; j<result.Length-1; j++)
            {
                if (result[j]>result[j+1])
                {
                    char buffer = result[j];
                    result = result.Remove(j,1).Insert(j, result[j+1].ToString());
                    result = result.Remove(j+1,1).Insert(j+1, buffer.ToString());
                }
            }
        return result;
    }

    static void WriteArray (char[] arr)
    {
        for (int i = 0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static char[] AddItem(char[] arr, char item) 
    {
        char[] result = new char[arr.Length+1];
        arr.CopyTo(result, 0);
        result[arr.Length] = item;
        return result;
    }

    static char[] Duplicate(string str)
    {        
        if (str.Length == 0) return Array.Empty<char>();
        str = Sort(str);
        char[] result = Array.Empty<char>();
        for (int i = 0; i<str.Length-1; i++)
        {
            if (str[i] == str[i+1])
            {
                if (result.Length == 0) {
                    result = AddItem(result, str[i]);
                } else { 
                    if (str[i] != result[result.Length-1])
                    {
                        result = AddItem(result, str[i]);
                    }
                }
            }
        }
        return result;
    }
    private static void Main(string[] args)
    {
        string a = "asdasdasdvbsidvussioixcvuwer";
        string b = "qwertyuiopasdfghjklzxcvbnm,./;'[]1234567890-!@#$%^&*()_QWERTYUIOPASDFGHJKLZXCVBNM<>:";

        Console.WriteLine(Compare(a,b));
        Console.WriteLine(a);
        Console.WriteLine(Sort(a));
        Console.WriteLine(a);

        (int,int,int) analyze;
        analyze = Analyze(b);
        Console.WriteLine($"Laters: {analyze.Item1}, Digits: {analyze.Item2}, Another symbols: {analyze.Item3}");
        WriteArray(Duplicate(a));
        
    }

}