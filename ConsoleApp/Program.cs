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

void ShowRemoveStat() => WriteLine($"Removed: {removed}. Length: {list.Length}");

