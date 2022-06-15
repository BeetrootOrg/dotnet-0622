void WriteLineArray(int[] arr)
{
    foreach (var element in arr)
    {
        System.Console.WriteLine(element);
    }
}

void WriteLineArrayFor(int[] arr)
{
    for (var index = 0; index < arr.Length; ++index)
    {
        System.Console.WriteLine(arr[index]);
    }
}

void WriteLineArrayRecurssion(int[] arr)
{
    if (arr.Length == 0) return;
    System.Console.WriteLine(arr[0]);
    WriteLineArrayRecurssion(arr[1..]);
}

// analogues how to initialize array
int[] array1 = { 1, 2, 3 };
var array2 = new[] { 1, 2, 3 };
var array3 = new int[] { 1, 2, 3 };
var array4 = new int[3] { 1, 2, 3 };
var array5 = new int[3];

System.Console.WriteLine("FOREACH");
WriteLineArray(array1);
WriteLineArray(array2);
WriteLineArray(array3);
WriteLineArray(array4);
WriteLineArray(array5);

System.Console.WriteLine("FOR");
WriteLineArrayFor(array1);

System.Console.WriteLine("RECURSION");
WriteLineArrayRecurssion(array1);