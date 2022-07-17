class NewStack<T>
{
    private void NullCheck()
    {
        if (Count == 0)
        {
            throw new NullReferenceException();
        }
    }
    private record ItemNumber
    {
        public T Value { get; init; }
        public ItemNumber Next { get; set; }
    }

    private ItemNumber _head;
    public int Count { get; private set; }

    public void Push(T item)
    {
        var newItem = new ItemNumber
        {
            Value = item
        };
        newItem.Next = _head;
        _head = newItem;
        ++Count;
    }

    public T Pop()
    {        
        NullCheck();
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
        NullCheck();
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
} 