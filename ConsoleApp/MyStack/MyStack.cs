using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MyStack
{
    internal class MyStack<T> : IEnumerable<T>
    {
        private Element<T> _head;
        private int _count;

        public int GetCount
        {
            get { return _count; }
            set { }
        }

        public MyStack()
        {
            _head = null;
            _count = 0;
        }
        public MyStack(MyStack<T> stack) : this()
        {
            foreach (T item in stack)
            {
                Push(item);
            }
        }
        public bool isEmpty() => GetCount == 0 ? true : false;

        public T Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                throw new Exception();
            }
            Element<T> toReturn = _head;
            _head = toReturn.NextElement;
            _count--;
            return toReturn.Data;
        }

        public void Push(T argument)
        {
            Element<T> element = new Element<T>(argument);
            element.NextElement = _head;
            _head = element;
            _count++;
        }
        public void Push(params T[] arguments)
        {

            if (arguments.Length == 0)
            {
                Console.WriteLine("Arguments list is empty");
                return;
            }

            for (int i = 0; i < arguments.Length; ++i)
            {
                Push(arguments[i]);
            }
        }

        public T Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                Console.ReadKey();
                throw new Exception();
            }

            return _head.Data;
        }

        public T[] CopyTo()
        {
            MyStack<T> Copy = new MyStack<T>(this);
            T[] array = new T[Copy.GetCount];
            for (int i = 0; i <= Copy.GetCount; ++i)
            {
                array[i] = Copy.Peek();
                Copy.Pop();
            }

            return array;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Element<T> currentElement = _head;
            while (currentElement != null)
            {
                yield return currentElement.Data;
                currentElement = currentElement.NextElement;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
