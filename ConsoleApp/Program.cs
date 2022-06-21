internal class Program
{
    static void WriteArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    static int[] BubbleSortInt(int[] arr)
    {
        int[] copy = new int[arr.Length];
        Array.Copy(arr, copy, arr.Length);
        int temp = 0;
        for (int i = 0; i < copy.Length; i++)
        {
            for (int j = 0; j < copy.Length - 1; j++)
            {
                if (copy[j] > copy[j + 1])
                {
                    temp = copy[j];
                    copy[j] = copy[j + 1];
                    copy[j + 1] = temp;
                }
            }

        }
        WriteArray(copy);
        return copy;
    }
    private static void Main(string[] args)
    {
        int[] rightOrder = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] recursiveOrder = new int[] { 6, 5, 4, 3, 2, 1 };
        int[] numbers = new int[] { 1, 8, 3, 14, 55 };
        BubbleSortInt(rightOrder);
        BubbleSortInt(recursiveOrder);
        BubbleSortInt(numbers);
    }
}