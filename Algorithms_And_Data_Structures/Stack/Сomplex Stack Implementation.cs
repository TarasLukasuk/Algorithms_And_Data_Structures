using System;
using System.Collections;

namespace Algorithms_And_Data_Structures.Stack
{
    internal class СomplexStackImplementation<T> : IEnumerable
    {
        private ItemStack<T> Initial_Element { get; set; }
        public uint Count { get; private set; }

        private bool Is_Empty => Count == 0;

        public СomplexStackImplementation()
        {
            Initial_Element = null;
            Count = 0;
        }

        public СomplexStackImplementation(T data)
        {
            var item = new ItemStack<T>(data);
            Initial_Element = item;
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new ItemStack<T>(data);
            item.Previous = Initial_Element;
            Initial_Element = item;
            Count++;
        }

        public T Pop()
        {
            T result;
            if (!Is_Empty)
            {
                var item = Initial_Element;
                Initial_Element = Initial_Element.Previous;
                Count--;
                result = item.Data;
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
                result = Initial_Element.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Initial_Element;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
