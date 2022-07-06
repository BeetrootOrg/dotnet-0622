namespace ConsoleApp;

class MyStack<T>
{
    private StackItem _head;
    public int Count{get; private set;}
    protected class StackItem
    {
        public T Value {get;init;}
        public StackItem Next {get;set;}
    }

    public void Push(T value)
    {
        var newItem = new StackItem
        {
            Value = value,
            Next = _head
        };

        _head = newItem;
        Count++;
    }

    public void Pop()
    {
        if (_head != null) // else { do nothing, because stack already empty }
        {
            _head = _head.Next;
            Count--;
        }
    }

    public void Clear()
    {
        _head = null;
        Count = 0;
    }

    public T Peek()
    {
        return _head.Value;
    }

    public void CopyTo(T[] arr)
    {
        var currentItem = _head;
        for (int i = 0; i < arr.Length && currentItem != null; i++)
        {
            arr[i] = currentItem.Value;
            currentItem = currentItem.Next;
        }
    }
}