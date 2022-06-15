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

void Add3ToAll(int[] arr)
{
    for (var index = 0; index < arr.Length; ++index)
    {
        arr[index] += 3;
    }
}

void Add3ToAllWithReplace(int[] arr)
{
    var copy = new int[arr.Length];

    for (var index = 0; index < arr.Length; ++index)
    {
        copy[index] = arr[index] + 3;
    }

    arr = copy;
}

void Add3ToAllWithReplaceRef(ref int[] arr)
{
    var copy = new int[arr.Length];

    for (var index = 0; index < arr.Length; ++index)
    {
        copy[index] = arr[index] + 3;
    }

    arr = copy;
}

int[] MulBy2(int[] arr)
{
    var copy = new int[arr.Length];

    for (var index = 0; index < arr.Length; ++index)
    {
        copy[index] = arr[index] * 2;
    }

    return copy;
}

int[] MulBy3(int[] arr)
{
    var copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);

    for (var index = 0; index < arr.Length; ++index)
    {
        copy[index] *= 3;
    }

    return copy;
}

int SumAll(int[] values)
{
    var sum = 0;
    foreach (var item in values)
    {
        sum += item;
    }

    return sum;
}


int SumAllParams(params int[] values)
{
    var sum = 0;
    foreach (var item in values)
    {
        sum += item;
    }

    return sum;
}

System.Console.WriteLine($"{5.67890:N2}");
double b = Math.Round(5.67890, 2);

int[] Reverse(int[] arr)
{
    var copy = new int[arr.Length];
    for (var index = 0; index < arr.Length; index++)
    {
        copy[arr.Length - 1 - index] = arr[index];
    }

    return copy;
}

int[] ReverseReverse(int[] arr)
{
    var copy = new int[arr.Length];
    for (var index = arr.Length - 1; index >= 0; index--)
    {
        copy[index] = arr[arr.Length - index - 1];
    }

    return copy;
}

void ReverseRecursiveInternal(int[] arr, int[] result, int index = 0)
{
    if (index >= arr.Length) return;
    result[arr.Length - index - 1] = arr[index];
    ReverseRecursiveInternal(arr, result, index + 1);
}

int[] ReverseRecursive(int[] arr)
{
    var copy = new int[arr.Length];
    ReverseRecursiveInternal(arr, copy);
    return copy;
}

int[] InsertionSort(int[] arr)
{
    var copy = new int[arr.Length];
    Array.Copy(arr, copy, arr.Length);

    for (var i = 1; i < copy.Length; ++i)
    {
        var current = copy[i];
        var minIndex = i;
        for (var j = i - 1; j >= 0; --j)
        {
            var element = copy[j];

            if (element > current)
            {
                minIndex = j;
                copy[j + 1] = element;
            }
            else
            {
                break;
            }
        }

        copy[minIndex] = current;
    }

    return copy;
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

// empty array
var empty1 = new int[0];
var empty2 = Array.Empty<int>();

// add 3
System.Console.WriteLine("ADD 3");
Add3ToAll(array1);
WriteLineArray(array1);

System.Console.WriteLine("ADD 3 (WITH REPLACE)");
Add3ToAllWithReplace(array1);
WriteLineArray(array1);

System.Console.WriteLine("ADD 3 (WITH REPLACE REF)");
Add3ToAllWithReplaceRef(ref array1);
WriteLineArray(array1);

// Change length
System.Console.WriteLine("Resize");
Array.Resize(ref array1, 5);
WriteLineArray(array1);

// Multiply
System.Console.WriteLine("MULTIPLY");
var result1 = MulBy2(array1);
WriteLineArray(array1);
WriteLineArray(result1);

// Multiply
System.Console.WriteLine("MULTIPLY3");
var result2 = MulBy3(array1);
WriteLineArray(array1);
WriteLineArray(result2);

// SUM
SumAll(new[] { 1, 2, 3 });
// compilation error below
// SumAll(1, 2, 3);
// SumAll();

SumAllParams(new[] { 1, 2, 3 });
SumAllParams(1, 2, 3);
SumAllParams();
SumAllParams(1);

// REVERSE
System.Console.WriteLine("REVERSE");
result1 = Reverse(array1);
WriteLineArray(result1);

ReverseReverse(array1);

// REVERSE RECURSIVE
ReverseRecursive(array1);

// SORT
System.Console.WriteLine("SORTED");
WriteLineArray(InsertionSort(new[] { 1, 2, 3, 4, 5 }));
System.Console.WriteLine("REVERSE SORTED");
WriteLineArray(InsertionSort(new[] { 5, 4, 3, 2, 1 }));
System.Console.WriteLine("RANDOM SORTED");
WriteLineArray(InsertionSort(new[] { 1, 5, 0, 42, 6, 6, 5, 4, 2, 6 }));