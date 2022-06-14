internal class Program
{
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

        


    
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, -3, 5, 4, 6, -7, 8 };
        //Selection(array);
        Bubble(array);

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
        
}