using System;
using static System.Console;
namespace ConsoleApp;

class Stack<T>
{
    private record ListItem
    {
        public T Value { get; init; }
        public ListItem Previous { get; set; }
    }

    private ListItem _last;
    public int Height { get; private set; }

    public void Push(T value)
    {

        var newItem = new ListItem
        {
            Value = value,
        };

        if (_last != null) newItem.Previous = _last;

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
        if (_last == null) throw new NullReferenceException();
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