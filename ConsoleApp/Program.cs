void WriteLineArray(int[] arr)
{
    foreach (var a in arr)
    {
        System.Console.WriteLine(a);
    }
}

void WriteLineArrayFor(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

void WriteLineArrayRecursion(int[] arr)
{
    if (arr.Length == 0) return;
    System.Console.WriteLine(arr[0]);
    WriteLineArrayRecursion(arr[1..]);
}

//initialize
int[] array = { 1, 2, 3 };
var array2 = new[] { 1, 2, 3 };
var array3 = new int[] { 1, 2, 3 };
var array4 = new int[3] { 1, 2, 3 };
var array5 = new int [3];
WriteLineArray(array);
WriteLineArrayFor(array);
WriteLineArrayRecursion(array);