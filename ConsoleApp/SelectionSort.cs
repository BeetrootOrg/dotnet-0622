namespace ConsoleApp;

class SelectionSort
{
    public int[] Sort(int[] arr)
    {
        var copy = ArrayHelpers.Copy(arr);

        for (var i = 0; i < copy.Length - 1; i++)
        {
            var minIndex = i;

            for (var j = i + 1; j < copy.Length; ++j)
            {
                if (copy[minIndex] > copy[j])
                {
                    minIndex = j;
                }
            }

            var temp = copy[minIndex];
            copy[minIndex] = copy[i];
            copy[i] = temp;
        }

        return copy;
    }
}