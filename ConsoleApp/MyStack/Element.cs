using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MyStack
{
    internal class Element<T>
    {
        public T Data { get; set; }
        public Element<T> NextElement { get; set; }
        public Element(T data)
        {
            Data = data;
        }
    }
}
