int[] orig = { 8, 3, 6, 1, 0, 2, 9, 4, 7, 5 };

int[] SelectionSort(int[] arr)
{
    int a, b, min;
    int[] copy;

    copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);
    for (a = 0; a < copy.Length; ++a)
    {
        for (b = min = a; b < copy.Length; ++b)
        {
            if (copy[min] > copy[b])
            {
                min = b;
            }
        }
        b = min;
        min = copy[b];
        copy[b] = copy[a];
        copy[a] = min;
    }
    return copy;
}

int[] SelectionSort(int[] arr)
{
    int a, b, min;
    int[] copy;

    copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);
    for (a = 0; a < copy.Length; ++a)
    {
        for (b = min = a; b < copy.Length; ++b)
        {
            if (copy[min] > copy[b])
            {
                min = b;
            }
        }
        b = min;
        min = copy[b];
        copy[b] = copy[a];
        copy[a] = min;
    }
    return copy;
}
Console.WriteLine();
foreach (var pos in SelectionSort(orig))
{
    Console.Write($"{pos}, ");
}
Console.WriteLine();
