

int[] CopyArray(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    Array.Copy(arr, arrCopy, arr.Length);
    return arrCopy;
}

int[] SelectionSort(int[] array)
{
    int[] arr = CopyArray(array);
    int a, b, min;

    for (a = 0; a < arr.Length - 1; ++a)
    {
        min = a;
        for (b = min + 1; b < arr.Length; ++b)
        {
            min = arr[min] > arr[b] ? b : min;
        }
        b = arr[a];
        arr[a] = arr[min];
        arr[min] = b;
    }
    return arr;
}

int[] BubbleSortUpperLight(int[] array) //Variant 1. Upper a light object up.
{
    int[] arr = CopyArray(array);
    int a, b, min;

    for (a = 0; a < arr.Length - 1; ++a)
    {
        for (b = 0; b < arr.Length - 1 - a; ++b)
        {
            if (arr[b] < arr[b + 1])
            {
                min = arr[b];
                arr[b] = arr[b + 1];
                arr[b + 1] = min;
            }
        }
    }
    return arr;
}

int[] BubbleSortLowerHeavy(int[] array) //Variant 2. Lower heavy object down
{
    int[] arr = CopyArray(array);
    int a, b, min;

    for (a = 0; a < arr.Length - 1; ++a)
    {
        for (b = 0; b < arr.Length - 1 - a; ++b)
        {
            if (arr[b] > arr[b + 1])
            {
                min = arr[b];
                arr[b] = arr[b + 1];
                arr[b + 1] = min;
            }
        }
    }
    return arr;
}

int[] QuickSort(int[] arr, int lef, int rig)
{
    int basic = lef - 1;
    int temp = 0;

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

int[] orig = { 3, -5, 4, -8, 9, -2, 1, -7, 6, -6, -1, 7, -9, 2, -4, 8, -3, 5 };

void Output(string method, int[] orig, int[] arr)
{
    Console.WriteLine($"");
    Console.WriteLine($"{method}:");
    foreach (int elem in orig)
    {
        Console.Write($"{elem}, ");
    }
    Console.WriteLine($"");
    foreach (int elem in arr)
    {
        Console.Write($"{elem}, ");
    }
    Console.WriteLine($"");
}
Output("SelectionSort", orig, SelectionSort(orig));
Output("BubbleSortUpperLight", orig, BubbleSortUpperLight(orig));
Output("BubbleSortLowerHeavy", orig, BubbleSortLowerHeavy(orig));
Output("QuickSort", orig, QuickSort(CopyArray(orig), 0, orig.Length - 1));