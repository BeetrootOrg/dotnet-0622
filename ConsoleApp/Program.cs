internal class Program
{
    enum SortAlgorithmType
    {
        selection,
        bubble,
        insertion,
        quick
    }

    static int[] Sort (int[] array, SortAlgorithmType sortType, string orderBy = "asc")
    {  
        var copy = new int[array.Length];
        Array.Copy(array, copy, array.Length);
        
        switch ((int) sortType)
        {
            case 0:
                Selection(copy);
                break;
                
            case 1:
                Bubble(copy);
                break;
                
            case 2: 
                Insertion(copy); 
                break;
            
            default: 
            Quick(copy); 
            break;
        }

        if (orderBy == "desc") Array.Reverse(copy);
        
        return copy;
    }
    static int[] Selection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            return array;
        }

        static int[] Bubble(int[] array)
        {
            bool sorted;
            int j = 0;
            do {
                sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = true;
                    }
                }
                j++;
            }
            while (j < array.Length && sorted);    
            return array;
        }

        static int[] Insertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                    for ( int j = i; j > 0; j--)
                    {   
                        if (array[j] < array[j - 1])
                        {
                            int temp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;        
                        }
                        else break;   
                    }
            }
            return array;
        }

        static int[] Quick(int[] array, int start = 0, int end = 0)
        {   
   
            if (end == 0) end = array.Length - 1;
            
            int pivot = array[end];

            int i = start - 1;

            for (int j = start; j <= end; j++)
            {
              if (pivot >= array[j])
              {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
              }
            }

            if (i > 1) Quick (array, 0, (i - 1)); // left part
            if ((end - i) > 1) Quick (array, (i + 1), end); // right part
 
            return array;
        }
                   
    static void Main(string[] args)
    {
        int[] array = new int[] {10, 9, -8, -7, 6, -5, 4, 3, -2, 1};

        string orderBy = "asc";
        
        
        var result = Sort(array, SortAlgorithmType.quick, orderBy);

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }

        foreach (int item in result)
        {
            Console.WriteLine(item);
        }
    }   
}