namespace ConsoleApp;

class QuickSort
{
    public int[] Sort(int[] arr)
    {
        var copy = ArrayHelpers.Copy(arr);
        SortInternal(copy, 0, copy.Length - 1);
        return copy;
    }

    private void SortInternal(int[] arr, int left, int right)
    {
        if (left >= right || left < 0)
        {
            return;
        }

        var p = Partition(arr, left, right);
        SortInternal(arr, left, p - 1);
        SortInternal(arr, p + 1, right);
    }

    private int Partition(int[] arr, int left, int right)
    {
        var pivot = left - 1;
        int temp;

        for (var i = left; i < right; ++i)
        {
            if (arr[i] < arr[right])
            {
                ++pivot;
                temp = arr[i];
                arr[i] = arr[pivot];
                arr[pivot] = temp;
            }
        }

        ++pivot;
        temp = arr[pivot];
        arr[pivot] = arr[right];
        arr[right] = temp;

        return pivot;
    }
}