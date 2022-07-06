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
        Insert(value, Length);
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

    public void Insert(T value, int position)
    {
        if (position < 0 || position > Length)
        {
            throw new ArgumentOutOfRangeException(nameof(position));
        }

        var newItem = new ListItem
        {
            Value = value
        };

        if (position == 0)
        {
            newItem.Next = _head;
            _head = newItem;
        }
        else
        {
            var item = _head;

            for (int i = 0; i < position - 1; i++)
            {
                item = item.Next;
            }

            newItem.Next = item.Next;
            item.Next = newItem;
        }

        ++Length;
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

    public T[] ToArray()
    {
        var arr = new T[Length];
        CopyTo(arr);
        return arr;
    }
}