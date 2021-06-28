using System;
using Acme.Collections;

namespace C__study
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

            var s = new Stack<int>();
            s.Push(1); // stack contains 1
            s.Push(10); // stack contains 1, 10
            s.Push(100); // stack contains 1, 10, 100
            Console.WriteLine(s.Pop()); // stack contains 1, 10
            Console.WriteLine(s.Pop()); // stack contains 1
            Console.WriteLine(s.Pop()); // stack is empty

        }
    }
}


namespace Acme.Collections
{
    public class Stack<T>
    {
        Entry _top;
        
        public void Push(T data)
        {
            _top = new Entry(_top, data);
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException();
            }
            T result = _top.Data;
            _top = _top.Next;
            
            return result;
        }

        class Entry
        {
            public Entry Next { get; set; }
            public T Data { get; set; }
            
            public Entry(Entry next, T data)
            {
                Next = next;
                Data = data;
            }
        }
    }
}
