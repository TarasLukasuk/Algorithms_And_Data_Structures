using System;

namespace Algorithms_And_Data_Structures.linked_list
{
    internal class ListItem<T>
    {
        private T data = default(T);
        public ListItem<T> Next { get; set; }

        public ListItem(T data)
        {
            Data = data;
        }

        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                else
                {
                    data = value;
                }
            }
        }
    }
}
