internal class Program
{
    static bool Compare(string a, string b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i<a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }

    static int Analyze(string str, char sign)
    {
        if (str.Length == 0) return 0;
        int result=0;
        for (int i=0; i<str.Length; i++)
            if (str[i] == sign) result++;
        return result;
    }

    static string Sort(string str)
    {
        for (int i=0; i<str.Length; i++)
            for (int j=0; j<str.Length-1; j++)
            {
                if (str[j]>str[j+1])
                {
                    char buffer = str[j];
                    str = str.Remove(j,1).Insert(j, str[j+1].ToString());
                    str = str.Remove(j+1,1).Insert(j+1, buffer.ToString());
                }
            }
        return str;
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
        string a = "asdasdasd";
        string b = "qwertyuiopasdfghjklzxcvbnm,./;'[]1234567890-!@#$%^&*()_QWERTYUIOPASDFGHJKLZXCVBNM<>:";

        Console.WriteLine(Compare(a,b));
        Console.WriteLine(Sort(b));
        Console.WriteLine(b);
        WriteArray(Duplicate(a));
        
    }

}