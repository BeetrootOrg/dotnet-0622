using ConsoleApp;

var stack = new LinkedStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

stack.Pop();
stack.Clear();

System.Console.WriteLine(stack.Length);
