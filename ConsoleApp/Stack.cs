using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

class MyStack <T>
{
    public int Count { get; private set; }
    private Node _head;
    protected class Node
    {
        public T Value { get; set; }

        public Node Next { get; set; }
    }

    public void Push(T value)
    {
        if (_head == null)
        {
            _head = new Node();
            _head.Value = value;
            _head.Next = null;

            Count++;
        }
        else
        {
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node ()
            {
                Value = value,
                Next = null
            };
            Count++;
        }
    }

    public T Peek()
    {
        if (_head == null)
        {
            Console.WriteLine("Стек пустий");
            return default(T);
        }
        else
        {
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }

    public T Pop()
    {
        if (_head == null)
        {
            Console.WriteLine("Стек пустий");
            return default(T);
        }
        else
        {
            Node current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            Node temp = current.Next;
            current.Next = null;
            Count--;
            return temp.Value;
        }
    }

    public void Clear()
    {
        _head = null;
        Console.WriteLine("Стек очищено");
    }

    public void Copyto()
    {
        if (_head == null)
        {
            Console.WriteLine("Стек пустий");
        }
        else
        {
            Node current = _head;
            T[] array = new T[Count];
            int tempcount = 0;
            while (current != null)
            {
                array[tempcount] = current.Value;
                tempcount++;
                current = current.Next;
            }


        }
    }
    public void Copyto(T[] arr)
    {
        if (_head == null)
        {
            Console.WriteLine("Стек пустий");
        }
        else
        {
            Node current = _head;
            
            int tempcount = 0;
            while (current != null && tempcount<arr.Length)
            {
                arr[tempcount] = current.Value;
                tempcount++;
                current = current.Next;
            }


        }
    }

   

}


