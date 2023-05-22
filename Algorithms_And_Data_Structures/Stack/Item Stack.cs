namespace Algorithms_And_Data_Structures.Stack
{
    internal class ItemStack<T>
    {
        public T Data { get; set; }
        public ItemStack<T> Previous { get; set; }


        public ItemStack(T data)
        {
            Data = data;
        }
    }
}