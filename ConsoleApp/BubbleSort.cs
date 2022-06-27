namespace ConsoleApp;

class BubbleSort
{
    public int[] Sort(int[] arr)
    {
        var copy = ArrayHelpers.Copy(arr);

        for (var i = 0; i < copy.Length - 1; i++)
        {
            for (var j = 0; j < copy.Length - 1 - i; ++j)
            {
                if (copy[j] > copy[j + 1])
                {
                    var temp = copy[j];
                    copy[j] = copy[j + 1];
                    copy[j + 1] = temp;
                }
            }
        }

        return copy;
    }
}