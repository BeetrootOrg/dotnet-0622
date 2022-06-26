using System;

void PrintArray(params int[] array)
{
    Console.Write(string.Join(",", array));
    Console.WriteLine();
}

int[] Sort(int[] arr)
{
    // algorithm goes here
    return arr;
}

var arr1 = new[] { -5, 0, 1, 5, 17 };
var arr2 = new[] { 42, -5, -7, -15, -100 };
var arr3 = new[] { 42, -1, 14, 22, 5 };
var arr4 = Array.Empty<int>();
var arr5 = new[] { 42, 42, 42, 42, 42 };

PrintArray(Sort(arr1));
PrintArray(Sort(arr2));
PrintArray(Sort(arr3));
PrintArray(Sort(arr4));
PrintArray(Sort(arr5));