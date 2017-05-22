using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private Object _head;
        public Object Head { get { return _head; } set { _head = value; } }
        private readonly ArrayList _content;

        public Stack()
        {
            _content = new ArrayList();
        }

        public void Push(Object o)
        {
            if(o == null)
            {
                throw new InvalidOperationException("Can't push null references");
            }
            else
            {
                _content.Add(o);
                Head = o;
            }
        }

        public Object Pop()
        {
            if (_content.Count == 0)
            {
                throw new InvalidOperationException("Can't pop an empty stack");
            }
            else
            {
                var newHead = _content[_content.Count - 1];
                _content.RemoveAt(_content.Count - 1);
                Head = newHead;
                return Head;
            }            
        }

        public void Clear()
        {
            _content.Clear();
        }

        public void Print()
        {
            if(_content.Count == 0)
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                for(var i =0; i<_content.Count; i++)
                {
                    Console.WriteLine(_content[i]);
                }
            }
        }

    }
        
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                stack.Push(5);
                stack.Push("Alfa");
                stack.Push(5412);
                stack.Push("me");
                stack.Print();
                Console.WriteLine("--------");
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine("--------");
                //stack.Print();
                stack.Clear();
                stack.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
