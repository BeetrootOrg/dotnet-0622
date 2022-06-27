using System.Threading;

namespace ConsoleApp;

class Singleton
{
    public readonly static Singleton Instance = new Singleton();

    public int[] Keys { get; set; }

    private Singleton()
    {
        LoadData();
    }

    private void LoadData()
    {
        // so slow
        Thread.Sleep(2000);
        // complex request...
        Keys = new[] { 42, 42, 42 };
    }
}