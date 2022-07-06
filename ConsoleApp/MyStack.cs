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

    public T Pop()
    {
        try
        {
            var removedValue = _head.Value;
            _head = _head.Next;
            Count--;
            return removedValue;            
        }
        catch
        {
            throw new InvalidOperationException("Stack is empty");
        }
    }

    public void Clear()
    {
        _head = null;
        Count = 0;
    }

    public T Peek()
    {
        try
        {
            return _head.Value;
        }
        catch
        {
            throw new InvalidOperationException("Stack is empty");
        }
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