using System;
using static System.Console;
namespace ConsoleApp;

class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Previous { get; set; }
    }

    private StackItem _last;
    public int Height { get; private set; }

    public void Push(T value)
    {

        var newItem = new StackItem
        {
            Value = value,
        };

        newItem.Previous = _last;
        _last = newItem;
        Height++;

    }

    public T Pop()
    {
        if (_last == null) throw new NullReferenceException();

        T value = _last.Value;
        _last = _last.Previous;
        Height--;
        return value;
    }

    public void Clear()
    {
        _last = null;
        Height = 0;
    }

    public T Peek()
    {
        if (_last == null) throw new NullReferenceException();
        return _last.Value;
    }

    public int Count() => Height;

    public void CopyTo(T[] arr)
    {
        var item = _last;
        for (int i = 0; i < arr.Length && item != null; i++)
        {
            arr[i] = item.Value;
            item = item.Previous;
        }
    }
}