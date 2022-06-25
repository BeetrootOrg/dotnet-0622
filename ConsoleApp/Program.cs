int[] test = new int[] { 64, 25, 12, 22, 11 };
int[] test_1 = new int[] { 23, 2, 19, 0, 7 };

Console.WriteLine("Sorted array (bubble sort): ");
BubbleSort(test);
PrintArray(test);
Console.WriteLine();

Console.WriteLine("Sorted array (selection sort): ");
SelectionSort(test_1);
PrintArray(test_1);

static void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

static void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length -1; i++)
    {
        int smallest_index = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[smallest_index])
            {
                smallest_index = j;  
            }
        }
        int temp = arr[smallest_index];
        arr[smallest_index] = arr[i];
        arr[i] = temp;
    }
}

static void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}