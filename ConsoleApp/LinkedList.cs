using System;

namespace ConsoleApp;

class LinkedList<T>
{
    private record ListItem
    {
        public T Value { get; init; }
        public ListItem Next { get; set; }
    }

    private ListItem _head;
    public int Length { get; private set; }

    public void Add(T value)
    {
        var newItem = new ListItem
        {
            Value = value
        };

        if (Length == 0)
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

        ++Length;
    }

    public T Remove(int position)
    {
        if (position < 0 || position >= Length)
        {
            throw new ArgumentOutOfRangeException(nameof(position));
        }

        var item = _head;
        if (position == 0)
        {
            _head = _head.Next;
        }
        else
        {
            ListItem prevItem = null;
            for (int i = 0; i < position; i++)
            {
                prevItem = item;
                item = item.Next;
            }

            prevItem.Next = item.Next;
        }

        --Length;
        return item.Value;
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