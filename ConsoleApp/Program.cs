void WriteArr(int[] arr)
{
    foreach (var elem in arr)
    {
        System.Console.WriteLine(elem);
    }
}

void WriteArrFr(int[] arr)
{
   for (var index = 0; index < arr.Length; index++)
   {
    System.Console.WriteLine(arr[index]);
   }
}
void ArrRecurssion(int[] arr)
{
    
}

int[] array = { 1, 2, 3 };

var array2 = new[] { 1, 2, 3 };//+
var array3 = new int[] { 1, 2, 3 };//++

var array4 = new int[3] { 1, 2, 3 };
var array5 = new int[3];

WriteArr(array);
WriteArrFr(array2);