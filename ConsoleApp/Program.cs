
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
