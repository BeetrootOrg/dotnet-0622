class Stack<T>
{
    public SimpleList<T> Top { get; set; }

    public void Push(T obj)
    {
        SimpleList<T> newTop = new SimpleList<T>(obj);
        newTop.Next = Top;
        Top = newTop;
    }
}