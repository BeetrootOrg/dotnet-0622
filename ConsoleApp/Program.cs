
void PrintArray(params int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}
int[] BubbleSortArray(int[] array)
{
    var tempArray = new int[array.Length];
    Array.Copy(array, tempArray, array.Length);
    int tempVariable;
    for (int i = 0; i < tempArray.Length - 1; i++)
    {
        for (int j = i + 1; j < tempArray.Length; j++)
        {
            if (tempArray[i] > tempArray[j])
            {
                tempVariable = tempArray[i];
                tempArray[i] = tempArray[j];
                tempArray[j] = tempVariable;
            }
        }
    }
    return tempArray;
};

int[] SortArrayForKinds(int[] array)
{
    var tempArray = new int[array.Length];
    Array.Copy(array, tempArray, array.Length);
    Array.Sort(tempArray);
    return tempArray;
};
var initialArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
var initialArrayReverse = new[] { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
var initialArrayRandom = new[] { 26, 12, 6, 34, 18, 3, 2, 20, 0, 98 };

System.Console.WriteLine("initialArray");
PrintArray(initialArray);
System.Console.WriteLine("SortArrayForKinds");
var mass1 = SortArrayForKinds(initialArray);
PrintArray(mass1);
System.Console.WriteLine("BubbleSortArray");
var mass2 = BubbleSortArray(initialArray); //initialArrayReverse  initialArrayRandom
PrintArray(mass2);