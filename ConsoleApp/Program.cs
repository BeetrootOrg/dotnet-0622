
 using System;
 class Program 
 {
static int[] BubbleSortArray (int[] inputarr)
 {
    int[] resultarr = new int[inputarr.Length];
    Array.Copy(inputarr, resultarr, inputarr.Length); 
    for (int i = 0; i < resultarr.Length - 1; i++)
    {
        for (int j = i + 1; j < resultarr.Length; j++)
        { if (resultarr[i] < resultarr[j]) 
          {
             var temp = resultarr [i];
             resultarr [i] = resultarr [j];
             resultarr[j] = temp;
          }
        }
    }
    return resultarr;

 }

 static void Main (string[] args) 
 {
    int [] a = new int [] {12,24,13,15,16,17};
    int [] result = BubbleSortArray(a);
    foreach (var item in result)
    {
        System.Console.WriteLine(item);
    }

 } 
 }
