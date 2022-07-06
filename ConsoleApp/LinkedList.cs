namespace ConsoleApp;

class LinkedList<T>
{
    private record ListItem
    {
        public T Value { get; init; }
        public ListItem Next { get; set; }
    }

    private ListItem _head;

    public void Add(T value)
    {
        var newItem = new ListItem
        {
            Value = value
        };

        if (_head == null)
        {
            _head = newItem;
        }
        else
        {
            var item = _head;
            while (item.Next != null)
            {
                item = item.Next;
            }

            item.Next = newItem;
        }
    }
}