using System;
namespace ConsoleApp;
//using System.Collections.Generic;


class LinkedList<T>
{
    private record ListItem // create exempl one of list
    {
        public T Value { get; init;}
        public ListItem Next { get; set;}
    }
    private ListItem _head;
    public int Length {get; private set;}


    public void Add(T value)
    {
        var newItem = new ListItem
        {
            Next = null,
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