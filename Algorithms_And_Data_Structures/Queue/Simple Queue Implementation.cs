namespace Algorithms_And_Data_Structures.Queue
{
    internal class SimpleQueueImplementation<T>
    {
        private readonly List<T> items = new List<T>();

        private T Initial_Element => items.Last();
        public int Count { get => items.Count; }

        public SimpleQueueImplementation() { }

        public SimpleQueueImplementation(T data)
        {
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Dequeue()
        {
            var item = Initial_Element;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Initial_Element;
        }

    }
}
