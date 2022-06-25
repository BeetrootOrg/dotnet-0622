﻿
int[] SelectionSort(int[] arr)
{
    int a, b, min;
    int[] arrCopy = new int[arr.Length];
    Array.Copy(arr, arrCopy, arr.Length);

    for (a = 0; a < arrCopy.Length - 1; ++a)
    {
        min = a;
        for (b = min + 1; b < arrCopy.Length; ++b)
        {
            min = arrCopy[min] > arrCopy[b] ? b : min;
        }
        b = arrCopy[a];
        arrCopy[a] = arrCopy[min];
        arrCopy[min] = b;
    }
    return arrCopy;
}

int[] BubbleSortUpperLight(int[] arr) //Variant 1. Upper a light object up.
{
    int a, b, min;
    int[] arrCopy = new int[arr.Length];
    Array.Copy(arr, arrCopy, arr.Length);

    for (a = 0; a < arrCopy.Length - 1; ++a)
    {
        for (b = 0; b < arrCopy.Length - 1 - a; ++b)
        {
            if (arrCopy[b] < arrCopy[b + 1])
            {
                min = arrCopy[b];
                arrCopy[b] = arrCopy[b + 1];
                arrCopy[b + 1] = min;
            }
        }
    }
    return arrCopy;
}

int[] BubbleSortLowerHeavy(int[] arr) //Variant 2. Lower heavy object down
{
    int a, b, min;
    int[] arrCopy = new int[arr.Length];
    Array.Copy(arr, arrCopy, arr.Length);

    for (a = 0; a < arrCopy.Length - 1; ++a)
    {
        for (b = 0; b < arrCopy.Length - 1 - a; ++b)
        {
            if (arrCopy[b] > arrCopy[b + 1])
            {
                min = arrCopy[b];
                arrCopy[b] = arrCopy[b + 1];
                arrCopy[b + 1] = min;
            }
        }
    }
    return arrCopy;
}
