class Program
{
    static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex) return array;
            
        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
        //left sort
        QuickSort(array, minIndex, pivotIndex - 1);
        //right sort
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);

        return pivot;
    }

    static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }
        
    static void Main()
    {
        Console.Write("Input size array: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int[]  inputArray = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++) inputArray[i] = rnd.Next(-10, 10);
        
        Console.WriteLine($"Disordered array: {string.Join(", ", inputArray)}");

        int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

        Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");
    }

}
