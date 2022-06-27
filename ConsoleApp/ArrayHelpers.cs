using System;

namespace ConsoleApp;

class ArrayHelpers
{
    public static int[] Copy(int[] arr)
    {
        int[] copy = new int[arr.Length];
        Array.Copy(arr, copy, arr.Length);
        return copy;
    }
}