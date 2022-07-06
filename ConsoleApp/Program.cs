using ConsoleApp;

var stack1 = new MyStack<int>();
stack1.Pop();
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
stack1.Push(4);
stack1.Push(5);

stack1.Clear();
stack1.Pop();
Console.WriteLine(stack1.Count);