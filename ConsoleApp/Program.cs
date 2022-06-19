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

var arr1 = new[] { 1, 2, 3, 4, 5 };
var arr2 = new[] { 5, 4, 3, 2, 1 };
var arr3 = new[] { 3, 1, 4, 5, 2 };
var arr4 = Array.Empty<int>();
var arr5 = new[] { 1, 1, 1, 1, 1 };

PrintArray(Sort(arr1));
PrintArray(Sort(arr2));
PrintArray(Sort(arr3));
PrintArray(Sort(arr4));
PrintArray(Sort(arr5));