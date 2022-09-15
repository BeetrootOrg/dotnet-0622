
class Stack<T>
{
    public SimpleList<T> Top { get; set; }

    public int Count { get; private set; }

    public void Push(T obj)
    {
        SimpleList<T> newTop = new SimpleList<T>(obj);
        newTop.Next = Top;
        Top = newTop;
        ++Count;
    }

    public T Pop()
    {
        SimpleList<T> res = Top;
        Top = Top.Next;
        return res.Value;
        --Count;
    }

    public SimpleList<T> Peek()
    {
        return Top;
    }

    public void Clear()
    {
        Top = null;
        Count = 0;
    }

    public Stack()
    {
        Clear();
    }

    public void CopyTo(T[] arr)
    {
        var item = Top;
        for (int a = 0; a < arr.Length && item != null; ++a)
        {
            arr[a] = item.Value;
            item = item.Next;
        }
    }

    public Stack(SimpleList<T> obj)
    {
        if (obj != null)
        {
            Top = obj;
            Count = 1;
        }
        throw new NullReferenceException();
    }
}