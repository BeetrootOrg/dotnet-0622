static int[] Bubble(int[] array)
{
    int[] newarray = new int[array.Length];

    int temp = 0;

    Array.Copy(array, newarray, array.Length);

    foreach (var item in newarray)
    {
        for (int i = 0; i < newarray.Length - 1; i++)
        {
            for (int j = 0; j < newarray.Length - 1; j++)
            {
                if (newarray[i] > newarray[i + 1])
                {
                    temp = newarray[i + 1];
                    newarray[i + 1] = newarray[i];
                    newarray[i] = temp;
                }
                else
                    continue;
            }
        }
    }

    return newarray;
}

static int[] Selection(int [] array)
{
    int[] newarray = new int[array.Length];

    Array.Copy(array, newarray, array.Length);


    int temp, index = 0;


    for (int i = 0; i < newarray.Length; i++)
    {
        int min = newarray[i];

        for (int j = i; j < newarray.Length; j++)
        {
            if (min >= newarray[j]) // шукаємо мінімальне число в проході
            {
                index = j;         //запам*ятали індекс мінімального числа
                min = newarray[j];
            }
        }

        temp = newarray[i];
        newarray[i] = min;
        newarray[index] = temp;
        continue;
    }
    return newarray;
}



int[] array = { 9,8,7,6,5,4,3,2,1 };

foreach (var item in Bubble(array))
{
    Console.WriteLine(item);
}

foreach (var item in Selection(array))
{
    Console.WriteLine(item);
}





