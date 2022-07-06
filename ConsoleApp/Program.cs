using ConsoleApp;

using static System.Console;

var list = new LinkedList<int>();
WriteLine(list.Length);
list.Add(1);
WriteLine(list.Length);
list.Add(2);
WriteLine(list.Length);
list.Add(3);
WriteLine(list.Length);
list.Add(4);
WriteLine(list.Length);


var removed = list.Remove(0);
ShowRemoveStat();
removed = list.Remove(1);
ShowRemoveStat();
removed = list.Remove(1);
ShowRemoveStat();

list = new LinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);

var arr1 = new int[3];
var arr2 = new int[2];
var arr3 = new int[5];
var arr4 = list.ToArray();

list.CopyTo(arr1);
list.CopyTo(arr2);
list.CopyTo(arr3);

ShowArray(arr1);
ShowArray(arr2);
ShowArray(arr3);
ShowArray(arr4);

void ShowArray<T>(T[] arr) => WriteLine(string.Join(", ", arr));
void ShowRemoveStat() => WriteLine($"Removed: {removed}. Length: {list.Length}");

