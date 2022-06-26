void WritelineArray(int[] arr)
{
    foreach (var element in arr)
    {
        System.Console.WriteLine(element);
    }
}
 
int[] BubleSorted(int[] arr)
{
    var copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);

    for (var i = 1; i < copy.Length; ++i)
    {
        for (var j = 0; j < copy.Length; j++)
        {
            if (copy[j] > copy[j + 1])
            {
                var temp = copy[j];
                copy[j] = copy[j + 1];
                copy[j+1] = temp;
            }
        }
    }
    return copy;
}

//Sort
System.Console.WriteLine("Normal sorted");
WritelineArray(BubleSorted(new[] { 1, 2, 3, 4, 5 }));
System.Console.WriteLine("Rreverse sorted");
WritelineArray(BubleSorted(new[] { 5, 4, 3, 2, 1 }));
System.Console.WriteLine("Random number");
WritelineArray(BubleSorted(new[] { 5, 4, 3, 2, 1, 4, 12, 33, 4, 2, 5, 54 }));

