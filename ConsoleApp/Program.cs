using ConsoleApp;
internal class Program
{
    private static void Main(string[] args)
    {
       ConsoleApp.Stack<int> test = new ConsoleApp.Stack<int>();
       System.Console.WriteLine(test.Count);
       test.Push(10);
       test.Push(15);
       test.Push(20);
       test.Push(25);
       System.Console.WriteLine(test.Count);

       System.Console.WriteLine(test.Pop());
       System.Console.WriteLine(test.Count);
       System.Console.WriteLine(test.Pop());
       System.Console.WriteLine(test.Count);
       System.Console.WriteLine(test.Pop());
       System.Console.WriteLine(test.Count);
       
       test.Push(15);
       test.Push(20);
       test.Push(25);

       test.Clear();
       System.Console.WriteLine(test.Count);

       test.Push(10);
       test.Push(15);
       test.Push(20);
       test.Push(25);

       System.Console.WriteLine(test.Peek());
       System.Console.WriteLine(test.Peek());
       System.Console.WriteLine(test.Peek());
       System.Console.WriteLine(test.Peek());
       test.Clear();

       test.Push(10);
       test.Push(15);
       test.Push(20);
       test.Push(25);
       
       var testArr = new int[test.Count];
       test.CopyTo(testArr);
       WriteArray(testArr);
    }

    static void WriteArray<T>(IEnumerable<T> array)
    {
        System.Console.WriteLine(String.Join<T>(", ", array));
    }
}