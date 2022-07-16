namespace ConsoleApp;

class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Next { get; set; }
    }

    private StackItem _head;
    public int Count { get; private set; }

    public void Push(T value)
    {
        var newItem = new StackItem
        {
            Value = value
        };
        newItem.Next = _head;
        _head = newItem;
        Count++;
    }

    public T Pop()
    {
        var removedItem = _head;
        _head = _head.Next;
        Count--;
        return removedItem.Value;

    }

    public void Clear()
    {
        while (_head != null)
        {
            _head = _head.Next;
        }
    }

    public T Peek() => _head.Value;

    public void CopyTo(T[] arr)
    {
        var item = _head;
        for (int i = 0; i < Count; i++)
        {
            arr[i] = item.Value;
            item = item.Next;
        }
    }
}