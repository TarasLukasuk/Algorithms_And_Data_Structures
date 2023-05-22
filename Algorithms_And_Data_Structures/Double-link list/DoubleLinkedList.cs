using System.Collections;

namespace Algorithms_And_Data_Structures.Double_link_list
{
    internal class DoubleLinkedList<T> : IEnumerable, IEnumerable<T>
    {
        private DoubleLinkedListItem<T> Initial_Element { get; set; }
        private DoubleLinkedListItem<T> End_Element { get; set; }
        public uint Count { get; private set; }

        public DoubleLinkedList()
        {
            Initial_Element = null;
            End_Element = null;
            Count = 0;
        }

        public DoubleLinkedList(T data)
        {
            Add(data);
        }

        public void Add(T data)
        {
            var item = new DoubleLinkedListItem<T>(data);

            if (Count == 0)
            {
                Initial_Element = item;
                End_Element = item;
                Count = 1;
                return;
            }

            End_Element.Next = item;
            item.Previous = End_Element;
            End_Element = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Initial_Element;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public DoubleLinkedList<T> Revers()
        {
            var result = new DoubleLinkedList<T>();

            var current = End_Element;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Initial_Element;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
