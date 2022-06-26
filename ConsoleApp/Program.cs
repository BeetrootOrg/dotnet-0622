using System;

int[] Bubble(int[] array)
{
    int[] newArray = new int[array.Length];
    int temp = 0;
    Array.Copy(array, newArray, array.Length);
    var n = newArray.Length;
    bool needToSwap; //add bool value to track whether we need to swap the elements or not (try to dodge already in order arrays)
    for (int i = 0; i < n - 1; i++)
    {
        needToSwap = false;
        foreach (var item in newArray)
        {
            for (int j = 0; j < n - i - 1; j++)
                if (newArray[j] > newArray[j + 1])
                {
                    temp = newArray[j + 1];
                    newArray[j + 1] = newArray[j];
                    newArray[j] = temp;
                    needToSwap = true;
                }
            if (needToSwap == false)
                break;
        }
    }
    return newArray;
}

static void swap(int[] arr, int i, int j) //  swap function
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

static int partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = (low - 1); // Index of smaller element and indicates the right position of pivot found so far
    for (int j = low; j <= high - 1; j++)
    {
        if (arr[j] < pivot) // If current element is smallerthan the pivot
        {
            // Increment index of smaller element
            i++;
            swap(arr, i, j);
        }
    }
    swap(arr, i + 1, high);
    return (i + 1);
}

static void quickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int partIndex = partition(arr, low, high);
        quickSort(arr, low, partIndex - 1);
        quickSort(arr, partIndex + 1, high);
    }
}

static void printArray(int[] arr, int size) // func to print quickSort
{
    for (int i = 0; i < size; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

int[] array = { 3, 7, 9, 99, 13, 0, 1, 99, -10 };

Console.WriteLine("---BubleSort---");
Console.WriteLine("Sorted array: ");
foreach (var item in Bubble(array))
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine("---QuickSort---");
int n = array.Length;
quickSort(array, 0, n - 1);
Console.WriteLine("Sorted array: ");
printArray(array, n);
