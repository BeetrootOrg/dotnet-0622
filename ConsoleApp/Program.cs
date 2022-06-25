static int[] BubleSort(int[] arr)
{
    int[] copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);

    for (int i = 0; i < copy.Length - 1; ++i)
    {
        for (int j = 0; j < copy.Length - i - 1; ++j)
        {
            if (copy[j] > copy[j + 1])
            {
                int boof = copy[j];
                copy[j] = copy[j + 1];
                copy[j + 1] = boof;
            }
        }
    }

    return copy;
}
static int[] QuickSort(int[] array, int start = 0, int end = 0)
{

    if (end == 0) end = array.Length - 1;

    int pivot = array[end];
    // to keep the last swap number
    int i = start - 1;
    for (int j = start; j <= end; ++j)
    {
        if (pivot >= array[j])
        {
            ++i;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
    // to sort the right side of the arr
    if (i > 1) QuickSort(array, 0, (i - 1));
    // to sort the left side (if the right side is already sorted)
    if ((end - i) > 1) QuickSort(array, (i + 1), end);

    return array;
}

static int[] RandomArr()
{
    Random random = new Random(Environment.TickCount);
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 100);
    }
    return arr;
}

int[] arr = RandomArr();

foreach (var i in QuickSort(arr))
{
    Console.Write($"{i} ");
}
System.Console.WriteLine();
arr = RandomArr();
foreach (var i in BubleSort(arr))
{
    Console.Write($"{i} ");
}