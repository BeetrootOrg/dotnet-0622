internal class Program
{

    static void WriteArray (int[] arr)
    {
        for (int i = 0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void RandomArray (int[] arr)
    {
        for (int i = 0; i<arr.Length; i++)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            arr[i] = random.Next(100);
        }
    }

    static int[] CopyArray (int[] arr)
    {
        int[] copy = new int[arr.Length];
        for (int i=0; i<copy.Length; i++)
            copy[i] = arr[i];
        return copy;
    }
    
    static void Selection (int[] arr, OrderBy orderBy = OrderBy.Asc)
    {
        switch (orderBy)
        {
            case (OrderBy.Asc):
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    for (int j = i; j<arr.Length; j++)
                    {
                        int buffer;                    
                        if (arr[i] > arr[j]) 
                        {
                            buffer = arr[i];
                            arr[i] = arr[j];
                            arr[j] = buffer;
                        }
                    }            
                }                  
                break;
            }
            case (OrderBy.Desc):
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    for (int j = i; j<arr.Length; j++)
                    {
                        int buffer;                    
                        if (arr[i] < arr[j]) 
                        {
                            buffer = arr[i];
                            arr[i] = arr[j];
                            arr[j] = buffer;
                        }
                    }            
                }                  
                break;
            }
        }
    }

    static void Bubble (int[] arr, OrderBy orderBy = OrderBy.Asc)
    {
        switch (orderBy)
        {
            case (OrderBy.Asc):
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    for (int j = 0; j<arr.Length-1; j++)
                    {
                        int buffer;                    
                        if (arr[j] > arr[j+1]) 
                        {
                            buffer = arr[j];
                            arr[j] = arr[j+1];
                            arr[j+1] = buffer;
                        }
                    }            
                }
                break;
            }

            case (OrderBy.Desc):
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    for (int j = 0; j<arr.Length-1; j++)
                    {
                        int buffer;                    
                        if (arr[j] < arr[j+1]) 
                        {
                            buffer = arr[j];
                            arr[j] = arr[j+1];
                            arr[j+1] = buffer;
                        }
                    }            
                }
                break;
            }
        }       
    }

    static void Insertion (int[] arr, OrderBy orderBy = OrderBy.Asc)
    {
        switch (orderBy)
        {
            case (OrderBy.Asc):
            {
                for (int i = 1; i<arr.Length; i++)
                {
                    int current = arr[i];
                    int j;
                    for (j=i-1; j>=0; j--)
                    {
                        if (arr[j] < current) { 
                            break; 
                        } else {
                            arr[j+1] = arr[j];
                        }
                    
                    }
                    arr[j+1] = current;
                }
                break;
            }

            case (OrderBy.Desc):
            {
                for (int i = 1; i<arr.Length; i++)
                {
                    int current = arr[i];
                    int j;
                    for (j=i-1; j>=0; j--)
                    {
                        if (arr[j] > current) { 
                            break; 
                        } else {
                            arr[j+1] = arr[j];
                        }
                    
                    }
                    arr[j+1] = current;
                }
                break;
            }
        }
    }

    static void Qsort (int[] arr, OrderBy orderBy = OrderBy.Asc)
    {
        switch (orderBy)
        {
            case (OrderBy.Asc):
            {
                QsortAsc(arr).CopyTo(arr,0);                
                break;
            }

            case (OrderBy.Desc):
            {
                QsortDesc(arr).CopyTo(arr,0);
                break;
            }            
        }
    }

    static int[] AddItem(int[] arr, int item) 
    {
        int[] result = new int[arr.Length+1];
        arr.CopyTo(result, 0);
        result[arr.Length] = item;
        return result;
    }

    static int[] QsortAsc (int[] arr)
    {
        if (arr.Length == 0) return Array.Empty<int>();
        if (arr.Length == 1) return arr;
        int[] lower = Array.Empty<int>();
        int[] equal = new int[] {arr[0]};
        int[] greater = Array.Empty<int>();
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[0]) lower = AddItem(lower, arr[i]);
            if (arr[i] == arr[0]) equal = AddItem(equal, arr[i]);
            if (arr[i] > arr[0]) greater = AddItem(greater, arr[i]);
        }
        int[] result = new int[arr.Length];
        QsortAsc(lower).CopyTo(result, 0);
        QsortAsc(equal).CopyTo(result, lower.Length);
        QsortAsc(greater).CopyTo(result, lower.Length+equal.Length);
        return result;
    }
    static int[] QsortDesc (int[] arr)
    {
        if (arr.Length == 0) return Array.Empty<int>();
        if (arr.Length == 1) return arr;
        int[] lower = Array.Empty<int>();
        int[] equal = new int[] {arr[0]};
        int[] greater = Array.Empty<int>();
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[0]) lower = AddItem(lower, arr[i]);
            if (arr[i] == arr[0]) equal = AddItem(equal, arr[i]);
            if (arr[i] > arr[0]) greater = AddItem(greater, arr[i]);
        }
        int[] result = new int[arr.Length];
        QsortDesc(greater).CopyTo(result, 0);
        QsortDesc(equal).CopyTo(result, greater.Length);
        QsortDesc(lower).CopyTo(result, greater.Length+equal.Length);
        return result;
    }

    static int[] Sort(int[] arr, SortAlgorithmType sortAlgorithmType = SortAlgorithmType.Selection, OrderBy orderBy = OrderBy.Asc)
    {
        int[] copy = CopyArray(arr);
        switch (sortAlgorithmType)
        {
            case (SortAlgorithmType.Selection):
            {
                Selection(copy, orderBy);                
                break;
            }

            case (SortAlgorithmType.Bubble):
            {
                Bubble(copy, orderBy);
                break;
            }
            
            case (SortAlgorithmType.Insertion):
            {
                Insertion(copy, orderBy);
                break;
            }

            case (SortAlgorithmType.Qsort):
            {
                Qsort(copy, orderBy);
                break;
            }
        }
        return copy;
    }

    enum OrderBy {
        Asc,
        Desc
    }

    enum SortAlgorithmType{
        Selection,
        Bubble,
        Insertion,
        Qsort
    }
    
    private static void Main(string[] args)
    {        
        int n = 10;
        int[] array = new int[n];
        
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("SELECTION SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Selection));
        WriteArray(Sort(array, SortAlgorithmType.Selection, OrderBy.Desc));
        WriteArray(array);

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("BUBBLE SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Bubble));
        WriteArray(Sort(array, SortAlgorithmType.Bubble, OrderBy.Desc));
        WriteArray(array);

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Insertion SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Insertion));
        WriteArray(Sort(array, SortAlgorithmType.Insertion, OrderBy.Desc));
        WriteArray(array);

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("QUICK SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Qsort));
        WriteArray(Sort(array, SortAlgorithmType.Insertion, OrderBy.Desc));
        WriteArray(array);

        Console.WriteLine("-----------------------------------------------------");
    }
}