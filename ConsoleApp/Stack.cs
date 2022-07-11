namespace ConsoleApp;
class LinkedStack<T>
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
        if (_head == null)
        {
            _head = newItem;
            ++Length;
            return;
        }
        newItem.Next = _head;
        _head = newItem;
        ++Length;
    }

    // adds obj at the top of stack
    public T Pop()
    {
        Console.WriteLine("Item popped is {0}", _head.Value);
        var temp = _head;
        _head = _head.Next;
        Length--;
        Console.WriteLine("Item popped is {0}", _head.Value);
        return temp.Value;
    }
    public void Clear()
    {
    }
    public int Count()
    {
        return Length;
    }
    public T Peek()
    {
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