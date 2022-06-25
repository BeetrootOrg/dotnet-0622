
bool valid(string val)
{
    if (val != null & val.Length < 1)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool Compare(string val1, string val2)
{
    int a = 0; //index
    bool res = true;
    if (valid(val1) & valid(val2) & val1.Length == val2.Length)
    {
        a = val1.Length;

        while (a > -1)
        {
            if (val1[a] != val2[a])
            {
                res = false;
                break;
            }
            --a;
        }
        return res;
    }
    else
    {
        return false;
    }
}

(int alphNum, int digNum, int spechNum) Analyze(string val)
{
    int alphNum = 0;
    int digNum = 0;
    int spechNum = 0;
    if (valid(val))
    {
        for (int a = val.Length - 1; a > -1; --a)
        {
            digNum += char.IsDigit(val[a]) ? 1 : 0;
            alphNum += char.IsLetter(val[a]) ? 1 : 0;
            spechNum += char.IsSymbol(val[a]) ? 1 : 0;
            spechNum += char.IsPunctuation(val[a]) ? 1 : 0;
        }
    }
    return (alphNum, digNum, spechNum);
}

char[] QuickSort(char[] arr, int lef, int rig)
{
    int basic = lef - 1;
    char temp;

    if (lef < rig)
    {
        for (int a = lef; a < rig; ++a)
        {
            if (arr[a] < arr[rig])
            {
                ++basic;
                temp = arr[basic];
                arr[basic] = arr[a];
                arr[a] = temp;
            }
        }
        ++basic;
        temp = arr[basic];
        arr[basic] = arr[rig];
        arr[rig] = temp;
        QuickSort(arr, lef, rig - 1);
        QuickSort(arr, lef + 1, rig);
    }
    return arr;
}

string Sort(string val)
{
    if (valid(val))
    {
        val = new String(QuickSort(val.ToCharArray(), 0, val.Length - 1));
    }
    return val;
}

char[] Duplicate(string val)
{
    string res = string.Empty;
    char[] copy;
    if (valid(val))
    {
        copy = new string(val).ToLower().ToCharArray();
        for (int a = 0; a < copy.Length; ++a)
        {
            for (int b = a + 1; b < copy.Length; ++b)
            {
                if (!res.Contains(copy[a]) & copy[a] == copy[b])
                {
                    res += copy[a];
                }
            }
        }
    }
    return res.ToCharArray();
}
