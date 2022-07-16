namespace ConsoleApp;

public class Stack<T>
{
    record Item
    {
        public T Value { get; set; }
        public Item Next { get; set; }
    }
    private Item _top;
    public int Length { get; set; }

    public void Push(T value)
    {
        var newItem = new Item
        {
            Value = value
        };
        newItem.Next = _top;
        _top = newItem;
        ++Length;
    }
    public T Pop()
    {
        T item = _top.Value;
        _top = _top.Next;
        --Length;
        return item;
    }
    public T Peek() => _top.Value;
    public void Clear()
    {
        Length = 0;
        _top = null;
    }
    public int Count() => Length;
    public void CopyTo(T[] arr)
    {
        var item = _top;
        for (int i = 0; i < arr.Length && item != null; i++)
        {
            arr[i] = item.Value;
            item = item.Next;
        }
    }
}