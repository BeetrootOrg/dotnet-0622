int[] BubbleSort (int[] arr)
{
    var copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);
    var iterations = copy.Length;
    for (var i = 0; i < iterations - 1; i++)
    {
        for (var index = 0; index < iterations - i - 1; index++)
        {
            if (copy[index] > copy[index + 1])
            {
                var temp = copy[index];
                copy[index] = copy[index + 1]; 
                copy[index + 1] = temp;
            }
        }
    }
    return copy;
}