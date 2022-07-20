namespace ConsoleApp;

class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem Next { get; set; }
    }

    private StackItem _top;
    public int Count { get; private set; }

    public void Push(T value)
    {
        var item = new StackItem
        {
            Next = null,
            Value = value
        };

        item.Next = _top;
        _top = item;
        ++Count;
    }

    public T Pop()
    {
        var item = _top;
        _top = _top.Next;
        --Count;

        return item.Value;
    }

    public T Peek() => _top.Value;

    public void Clear()
    {
        _top = null;
        Count = 0;
    }

    public void CopyTo(T[] arr)
    {
        var item = _top;

        for (var i = 0; i < arr.Length && item != null; ++i, item = item.Next)
        {
            arr[i] = item.Value;
        }
    }
}