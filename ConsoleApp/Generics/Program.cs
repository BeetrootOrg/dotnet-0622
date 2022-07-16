
namespace ConsoleApp;

class Program
{
    static public void Main()
    {
        var stack = new Stack<int>();

        stack.Push(10);
        stack.Push(0);
        stack.Push(-6);

        var value = stack.Pop();
        System.Console.WriteLine("Top value = " + value);

        stack.Clear();

        stack.Count();
        System.Console.WriteLine(stack.Count());

        stack.Peek();
        System.Console.WriteLine(stack.Peek());

        int[] a = new int[] { };
        stack.CopyTo(a);
      
    }
}