using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms_And_Data_Structures.Stack
{
    internal class SimpleStackImplementation<T>
    {
        public int Count
        {
            get { return items.Count; }
        }

        private bool Is_Empty => items.Count == 0;

        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            T result;
            if (!Is_Empty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                result = item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
            return result;
        }

        public T Peek()
        {
            T result;
            if (!Is_Empty)
            {
                var item = items.LastOrDefault();
                result = item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }

            return result;
        }
    }
}
