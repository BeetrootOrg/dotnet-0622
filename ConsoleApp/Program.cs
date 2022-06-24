int[] asd = { 31, 3, 2, 32, 6, 56, 45, 4, -2, 6 };

int[] BubleSort(int[] array)
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
    Console.WriteLine(tempVariabl);
};


BubleSort(asd);