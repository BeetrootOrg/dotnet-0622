class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Next { get; set; }
    }

    private StackItem _topElement;
    public int Count { get; private set; }

    public T Pop()
    {
        if(Count == 0) return default(T);
        var item = _topElement;
        _topElement = _topElement.Next;
        --Count;
        return item.Value;
    }

    public void Clear()
    {
        while(Count > 0)
        {
            var item = _topElement;
            _topElement = _topElement.Next;
            --Count;
        }
    }

    public void Push(T value)
    {
        var newItem = new StackItem { Value = value };
        newItem.Next = _topElement;
        _topElement = newItem;
        ++Count;
    }

    public T Peek() => Count == 0 ? default(T) : _topElement.Value;

    public void CopyTo(T[] arr)
    {
        var item = _topElement;
        for (var i = 0; i < arr.Length && item != null; ++i)
        {
            arr[i] = item.Value;
            item = item.Next;
        }
    }

    public T[] ToArray()
    {
        var arr = new T[Count];
        CopyTo(arr);
        return arr;
    }
}