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
    
    static int[] Selection (int[] arr, OrderBy orderBy = OrderBy.Asc)
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
        return arr;
    }

    static int[] Bubble (int[] arr, OrderBy orderBy = OrderBy.Asc)
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
        return arr;        
    }

    static int[] Insertion (int[] arr, OrderBy orderBy = OrderBy.Asc)
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
        return arr;
    }

    static int[] Sort(int[] arr, SortAlgorithmType sortAlgorithmType = SortAlgorithmType.Selection, OrderBy orderBy = OrderBy.Asc)
    {
        switch (sortAlgorithmType)
        {
            case (SortAlgorithmType.Selection):
            {
                Selection(arr, orderBy);                
                break;
            }

            case (SortAlgorithmType.Bubble):
            {
                Bubble(arr, orderBy);
                break;
            }
            
            case (SortAlgorithmType.Insertion):
            {
                Insertion(arr, orderBy);
                break;
            }
        }
        return arr;
    }

    enum OrderBy {
        Asc,
        Desc
    }

    enum SortAlgorithmType{
        Selection,
        Bubble,
        Insertion
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

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("BUBBLE SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Bubble));
        WriteArray(Sort(array, SortAlgorithmType.Bubble, OrderBy.Desc));

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Insertion SORT:");
        RandomArray(array);
        WriteArray(array);
        WriteArray(Sort(array, SortAlgorithmType.Insertion));
        WriteArray(Sort(array, SortAlgorithmType.Insertion, OrderBy.Desc));

        Console.WriteLine("-----------------------------------------------------");
    }
}