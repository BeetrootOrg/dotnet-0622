using System;
using static System.Console;
namespace ConsoleApp;
using ConsoleApp;

class Program 
{
    public static void Main() 
    {
        
    var stack = new Stack<string>();

   stack.Push("first element");
   stack.Push("second element");
   stack.Push("last element");
    WriteLine(stack.Peek());
    WriteLine(stack.Count());  

    WriteLine(stack.Pop());
    WriteLine(stack.Peek());
    WriteLine(stack.Count());


   // stack.Clear();
    //WriteLine(stack.Peek());
    WriteLine(stack.Count());  
    stack.Push("last-last element");
    WriteLine(stack.Peek());
    WriteLine(stack.Count());  

    
    string [] arr = new string[2];
    stack.CopyTo(arr);
    ShowArray(arr);
    void ShowArray<T>(T[] arr) => WriteLine(string.Join(", ", arr));

    }
}