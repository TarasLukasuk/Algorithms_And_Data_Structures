namespace Algorithms_And_Data_Structures.Double_link_list
{
    internal class DoubleLinkedListItem<T>
    {
        public T Data { get; set; }
        public DoubleLinkedListItem<T> Previous { get; set; }
        public DoubleLinkedListItem<T> Next { get; set; }

        public DoubleLinkedListItem(T data)
        {
            Data = data;
        }
    }
}