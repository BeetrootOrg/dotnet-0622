internal class Program
{
    static void WriteArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        System.Console.WriteLine();
    }     
    static int[] SelectionSort(int[] arr)
    {
        int[] copyArr = new int[arr.Length];
        Array.Copy(arr, copyArr, arr.Length);

        for (int i = 0; i < copyArr.Length - 1; i++)
        {
            var smallestNumberIndex = i;

            for (int j = i + 1; j < copyArr.Length; j++)
            {
                if (copyArr[j] < copyArr[smallestNumberIndex])
                {
                    smallestNumberIndex = j;
                }
            }

            var temp = copyArr[smallestNumberIndex];
            copyArr[smallestNumberIndex] = copyArr[i];
            copyArr[i] = temp;
        }
        return copyArr;
    }
    private static void Main(string[] args)
    {       
        int[] myArray = {159, 433, 187, 58, 367};
        WriteArray(myArray);
        WriteArray(SelectionSort(myArray));
    }
}