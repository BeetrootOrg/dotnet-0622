namespace ConsoleApp;

class StackA<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Next { get; set; }
        
    }
    private StackItem _head;
    public int Length { get; private set; }

    public void Push(T value)
    {
        var newItem = new StackItem
        {
            Value = value
        };
        if (Length == 0)
        {
            _head = newItem;
        }
        else
        {
            newItem.Next = _head;
            _head = newItem;
        }
        
        ++Length;
    }

    public T Pop()
    {
        if (_head == null) throw new NullReferenceException();
        T item = _head.Value;
        _head = _head.Next;
        --Length;
        return item;
    }

    public void Clear()
    {
        if (_head == null) throw new NullReferenceException();

        _head = null;
        Length = 0;
    }

    public T Peek()
    {
        if (_head == null) throw new NullReferenceException();
        return _head.Value;
    }

    public int Count() => Length;

    public void CopyTo(T[] arr)
    {
        var item = _head;
        for (int i = 0; i < arr.Length && item != null; i++)
        {
            arr[i] = item.Value;
            item = item.Next;
        }
    }
}