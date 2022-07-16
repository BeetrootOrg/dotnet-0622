namespace ConsoleApp;
using System;
using static System.Console;

class Program
{
    private static void Main(string[] arg)
    {
        var stack = new Stack<string>();
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");
        stack.Push("Four");
        WriteLine(stack.Count());
        stack.Clear();
        WriteLine(stack.Count());
        
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");
        stack.Push("Four");
        WriteLine(stack.Peek());
        WriteLine(stack.Pop());
        WriteLine(stack.Count());

    }
}