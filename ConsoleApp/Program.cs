static bool Compare(string first, string second)
{
    if (first.Length != second.Length)
    {
        return false;
    }
    else if (first.Length == second.Length)
    {
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                return false;
            }
            else if (first[i] == second[i])
            {
                continue;
            }
        }

    }
    return true;
}

static void Analyze(string first)
{
    int charcount = 0, digitcount = 0, symbolcount = 0;

    foreach (var item in first)
    {
        if (Char.IsLetter(item))
        {
            charcount++;
        }
        else if (Char.IsDigit(item))
        {
            digitcount++;
        }
        else if (Char.IsSymbol(item) || Char.IsPunctuation(item))
        {
            symbolcount++;
        }
    }

    Console.WriteLine($"Букв у масиві : {charcount}");
    Console.WriteLine($"Цифр у масиві : {digitcount}");
    Console.WriteLine($"Символів у масиві : {symbolcount}");
}

static string Sort(string first)

{
    string sorted = first.ToLower();

    char[] temparray = new char[sorted.Length];

    int counter = 0;
    foreach (var item in sorted)  // тут не використав Array.Sort, бо в мене виникала помилка, не захотіло сортувати. Прийшлось писать руцями
    {
        temparray[counter] = item;
        counter++;
    }
    Array.Sort(temparray);
    sorted = "";
    foreach (var item in temparray)     // тут не використав String.join тому що там треба вставляти сепаратор, а мені треба без сепаратора
    {
        sorted += item;
    }
    return sorted;
}


static char[] Duplicate(string first)
{
    string tempstr = "";
    string inwork = first.ToLower();

    for (int i = 0; i < inwork.Length; i++)
    {
        char ch = inwork[i];
        for (int j = i + 1; j < inwork.Length; j++)
        {
            if (inwork[j] == ch)
            {
                tempstr += ch;
                break;
            }
        }
    }
    char[] resultarray = new char[tempstr.Length]; // перероблюю строку в масив
    for (int i = 0; i < resultarray.Length; i++)   //     
    {
        resultarray[i] = tempstr[i];
    }
    return resultarray;

}

