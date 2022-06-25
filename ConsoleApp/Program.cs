
bool Compare(string val1, string val2)
{
    int a = 0; //index
    bool res = true;
    if (val1 is null & val2 is null)
    {
        return false;
    }
    if (val1.Length < 1 & val2.Length < 1 & val1.Length != val2.Length)
    {
        return false;
    }
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