
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

    public T Peek()
    {
        if (Top != null)
        {
            return Top.Value;
        }
        throw new NullReferenceException();
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