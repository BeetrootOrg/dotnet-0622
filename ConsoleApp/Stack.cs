using System;

namespace ConsoleApp;

class Stack<T>
{
    private record ListItem
    {
        public T Value { get; init; }
        public ListItem Next { get; set; }
    }

    private ListItem _head;
    public int Count { get; private set; }

    public void Push(T item)
    {
        var newItem = new ListItem
        {
            Value = item
        };
        newItem.Next = _head;
        _head = newItem;
        ++Count;
    }

    public T Pop()
    {        
        ValidateCount();
        var itemToReturn = _head.Value;
        _head = _head.Next;
        --Count;
        return itemToReturn;
    }

    public void Clear()
    {
        _head = null;
        Count = 0;
    }
    public T Peek()
    {
        ValidateCount();
        return _head.Value;
    }

    public void CopyTo(T[] arr)
    {
        var item = _head;
        for (var i = 0; i < arr.Length && item != null; ++i)
        {
            arr[i] = item.Value;
            item = item.Next;
        }
    }

    private void ValidateCount()
    {
        if (Count == 0)
        {
            throw new InvalidDataException("No Elements in Stack");
        }
    }
}