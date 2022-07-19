namespace ConsoleApp;
using System;


class Stack<T>
{
    private record StackItem
    {
        public T Value { get; init; }
        public StackItem LinkToNextItem { get; set; }
    }

    private StackItem _headOfStack;
    public int LengthOfStack { get; private set; }

    public void Add(T value)
    {
        Insert(value, LengthOfStack);
    }

    public T Remove(int position)
    {
        if (position < 0 || position >= LengthOfStack)
        {
            throw new ArgumentOutOfRangeException(nameof(position));
        }

        var item = _headOfStack;
        if (position == 0)
        {
            _headOfStack = _headOfStack.LinkToNextItem;
        }
        else
        {
            StackItem prevItem = null;
            for (int i = 0; i < position; i++)
            {
                prevItem = item;
                item = item.LinkToNextItem;
            }

            prevItem.LinkToNextItem = item.LinkToNextItem;
        }

        --LengthOfStack;
        return item.Value;
    }

    public void Insert(T value, int position)
    {
        if (position < 0 || position > LengthOfStack)
        {
            throw new ArgumentOutOfRangeException(nameof(position));
        }

        var newItem = new StackItem
        {
            Value = value
        };

        if (position == 0)
        {
            newItem.LinkToNextItem = _headOfStack;
            _headOfStack = newItem;
        }
        else
        {
            var item = _headOfStack;

            for (int i = 0; i < position - 1; i++)
            {
                item = item.LinkToNextItem;
            }

            newItem.LinkToNextItem = item.LinkToNextItem;
            item.LinkToNextItem = newItem;
        }

        ++LengthOfStack;
    }

    public void CopyTo(T[] arr)
    {
        var item = _headOfStack;
        for (var i = 0; i < arr.LengthOfStack && item != null; ++i)
        {
            arr[i] = item.Value;
            item = item.LinkToNextItem;
        }
    }

    public T[] ToArray()
    {
        var arr = new T[LengthOfStack];
        CopyTo(arr);
        return arr;
    }


    // void Push(obj) - adds obj at the top of stack
    // T Pop() - returns top element of stack & removes it
    //     void Clear() - clear stack

    // int Count - property return number of elements

    // T Peek() - returns top element but doesn’t remove it

    // void CopyTo(arr) - copies stack to array




}