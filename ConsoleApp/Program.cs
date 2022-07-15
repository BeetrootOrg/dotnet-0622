// using static System.Console;
// using System.Collections.Generic;


// // void Swap<T>(ref T val1, ref T val2)
// // {
// //     var temp = val1;
// //     val1 = val2;
// //     val2 = temp;
// // }

// // var a = 1;
// // var b = 3;
// // WriteLine("a= " + a + "b= "+b);
// // Swap(ref a, ref b);


// // WriteLine("a= " + a + "b= "+b);


// using ConsoleApp;

// using static System.Console;

// var list = new LinkedList<int>();
// WriteLine(list.Length);
// list.Add(1);
// WriteLine(list.Length);
// list.Add(2);
// WriteLine(list.Length);
// list.Add(3);
// WriteLine(list.Length);
// list.Add(4);
// WriteLine(list.Length);


// var removed = list.Remove(0);
// ShowRemoveStat();
// removed = list.Remove(1);
// ShowRemoveStat();
// removed = list.Remove(1);
// ShowRemoveStat();

// list = new LinkedList<int>();
// list.Add(1);
// list.Add(2);
// list.Add(3);

// var arr1 = new int[3];
// var arr2 = new int[2];
// var arr3 = new int[5];
// var arr4 = list.ToArray();

// list.CopyTo(arr1);
// list.CopyTo(arr2);
// list.CopyTo(arr3);

// ShowArray(arr1);
// ShowArray(arr2);
// ShowArray(arr3);
// ShowArray(arr4);

// list.Add(4);

// list.Insert(0, 2);
// ShowArray(list.ToArray());

// void ShowArray<T>(T[] arr) => WriteLine(string.Join(", ", arr));
// void ShowRemoveStat() => WriteLine($"Removed: {removed}. Length: {list.Length}");