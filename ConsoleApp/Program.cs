void WriteLineArray(int[] arr)
{
    foreach (var element in arr)
    {
        System.Console.WriteLine(element);
    }
}

// analogues how to initialize array
int[] array1 = { 1, 2, 3 };
var array2 = new[] { 1, 2, 3 };
var array3 = new int[] { 1, 2, 3 };
var array4 = new int[3] { 1, 2, 3 };
var array5 = new int[3];

WriteLineArray(array1);
WriteLineArray(array2);
WriteLineArray(array3);
WriteLineArray(array4);
WriteLineArray(array5);