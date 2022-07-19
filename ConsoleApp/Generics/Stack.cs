using System;
namespace ConsoleApp;

class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Previous { get; set; }

    }
    private StackItem _head;
    public int Count { get; private set; }
    public void Push(T element)
    {
        var newItem = new StackItem
        {
            Value = element

        };

        if (_head != null)
            newItem.Previous = _head;

        _head = newItem;

        ++Length;

    }
    public T Pop()
    {
        if (_head != null)
        {
            var temp = _head.Value;
            _head = _head.Previous;
            --Length;
            return temp;
        }
        else
        {
            throw new NullReferenceException();
        }

    }


    public void Clear()
    {
        if (_head != null)
        {
            _head = null;
            Length = 0;
        }

    }
    public int Count() => Length;

    public T Peek()
    {
        if (_head == null)
        {
            throw new NullReferenceException();
        }
        return _head.Value;

    }

    public void CopyTo(T[] arr)
    {
        var item = _head;
        for (var i = 0; i < arr.Length && item != null; ++i)
        {
            arr[i] = item.Value;
            item = item.Previous;
        }

    }
}