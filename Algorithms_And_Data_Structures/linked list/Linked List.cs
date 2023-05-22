using System.Collections;

namespace Algorithms_And_Data_Structures.linked_list
{
    internal class LinkedList<T> : IEnumerable
    {
        private ListItem<T> Initial_Element { get; set; }
        private ListItem<T> End_Element { get; set; }

        public uint Count { get; private set; }

        public LinkedList()
        {
            Clear_List();
        }

        public LinkedList(T data)
        {

            Set_Initial_Element_And_End_Element(data);
        }

        public void Add(T data)
        {
            var item = new ListItem<T>(data);

            if (End_Element == null)
            {
                Set_Initial_Element_And_End_Element(data);
            }
            else
            {
                End_Element.Next = item;
                End_Element = item;
                Count++;
            }
        }

        public void Delete(T data)
        {
            if (Initial_Element != null)
            {
                if (Initial_Element.Data.Equals(data))
                {
                    Initial_Element = Initial_Element.Next;
                    Count--;
                    return;
                }

                var current = Initial_Element.Next;
                var previous = Initial_Element;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                Set_Initial_Element_And_End_Element(data);
            }
        }

        public void Clear_List()
        {
            Initial_Element = null;
            End_Element = null;
            Count = 0;
        }

        public void Appemd_Initial_Element(T data)
        {
            var item = new ListItem<T>(data);
            item.Next = Initial_Element;
            Initial_Element = item;
            Count++;
        }

        public void Insert_After(T target, T data)
        {
            if (Initial_Element != null)
            {
                var curent = Initial_Element;
                while (curent != null)
                {
                    if (Initial_Element.Data.Equals(target))
                    {
                        var item = new ListItem<T>(data);
                        item.Next = curent.Next;
                        curent.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        curent = curent.Next;
                    }
                }
            }
            else
            {
                Set_Initial_Element_And_End_Element(target);
            }
        }

        private void Set_Initial_Element_And_End_Element(T data)
        {
            var item = new ListItem<T>(data);
            Initial_Element = item;
            End_Element = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Initial_Element;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
