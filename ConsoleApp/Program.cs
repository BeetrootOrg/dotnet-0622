using ConsoleApp.MyStack;

MyStack<string> myStack = new MyStack<string>();

myStack.Push("a", "b", "c", "d");
Console.WriteLine(myStack.Peek());
myStack.Pop();
Console.WriteLine(myStack.Peek());
myStack.Pop();
Console.WriteLine(myStack.Peek());
string[] list = new string[2];
list = myStack.CopyTo();
Console.WriteLine(list);