using static System.Console;

var list = new Stack<int>();

list.Push(78);
list.Push(45);
list.Push(-4);
System.Console.Write("New list: ");
ShowArray(list.ToArray());
System.Console.Write("Peek: ");
System.Console.WriteLine(list.Peek());
System.Console.Write("Method Pop: ");
System.Console.WriteLine(list.Pop());
System.Console.Write("New list after pop: ");
ShowArray(list.ToArray());
System.Console.Write("New list after clear: ");
list.Clear();
ShowArray(list.ToArray());
void ShowArray<T>(T[] arr) => WriteLine(string.Join(", ", arr));