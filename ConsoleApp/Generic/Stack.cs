class Stack<T>
{
    public SimpleList<T> Top { get; set; }

    public void Push(T obj)
    {
        SimpleList<T> newTop = new SimpleList<T>(obj);
        newTop.Next = Top;
        Top = newTop;
    }

    public T Pop()
    {
        SimpleList<T> res = Top;
        Top = Top.Next;
        return res.Value;
    }
}