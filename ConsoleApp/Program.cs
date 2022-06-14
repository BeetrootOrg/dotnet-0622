internal class Program
{
    enum SortAlgorithmType
    {
        selection,
        bubble,
        insertion
    }

    static int[] Sort (int[] array, SortAlgorithmType sortType, string orderBy = "asc")
    {  
        int sort = (int) sortType;
        
        switch (sort)
        {
            case 0:
            {
                Selection(array);
                break;
            }    
            case 1:
            {
                Bubble(array);
                break;
            }    
            default: 
                Insertion(array); 
                break;
        }

        if (orderBy == "desc") Array.Reverse(array);
        
        return array;
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
    static void Main(string[] args)
    {
        int[] array = new int[] { 9, -3, 5, 4, 6, -7, -8 };

        string orderBy = "desc";
        Sort(array, SortAlgorithmType.insertion, orderBy);

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }   
}