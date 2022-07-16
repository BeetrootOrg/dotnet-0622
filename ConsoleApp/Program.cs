using ConsoleApp;
using static System.Console;


var NewStack = new ConsoleApp.Stack<int>();
NewStack.Push(1);
NewStack.Push(12);
NewStack.Push(4);
NewStack.Push(67);
NewStack.Pop();
WriteLine(NewStack.Count);
WriteLine(NewStack.Pop());

