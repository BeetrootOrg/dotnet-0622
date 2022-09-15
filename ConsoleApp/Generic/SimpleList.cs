
public class SimpleList<T>
{
    public T Value { get; set; }

    public SimpleList<T> Next { get; set; }

    public SimpleList(T value) => Value = value;
}