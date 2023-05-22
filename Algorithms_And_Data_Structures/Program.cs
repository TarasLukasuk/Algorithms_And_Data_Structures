using Algorithms_And_Data_Structures.Binary_search_tree;
using Algorithms_And_Data_Structures.Queue;
using Algorithms_And_Data_Structures.Stack;

namespace Algorithms_And_Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("single-link list" + Environment.NewLine);

            var linked_List = new linked_list.LinkedList<int>
            {
                3, 45, 102, 103, 104, 104, 105, 104, 1045, 100345
            };

            linked_List.Insert_After(3, 200);

            foreach (var item in linked_List)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine + "stack" + Environment.NewLine);

            var сomplex_Stack_Implementation = new СomplexStackImplementation<int>();
            сomplex_Stack_Implementation.Push(4);
            сomplex_Stack_Implementation.Push(22);
            сomplex_Stack_Implementation.Push(66);
            сomplex_Stack_Implementation.Push(88);
            сomplex_Stack_Implementation.Push(77);
            сomplex_Stack_Implementation.Push(101);

            foreach (var item in сomplex_Stack_Implementation)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine + "queue" + Environment.NewLine);

            var simple_Queue_Implementation = new SimpleQueueImplementation<int>();
            simple_Queue_Implementation.Enqueue(4);
            simple_Queue_Implementation.Enqueue(22);
            simple_Queue_Implementation.Enqueue(66);
            simple_Queue_Implementation.Enqueue(88);
            simple_Queue_Implementation.Enqueue(77);
            simple_Queue_Implementation.Enqueue(101);

            Console.WriteLine(simple_Queue_Implementation.Dequeue());
            Console.WriteLine(simple_Queue_Implementation.Peek());
            Console.WriteLine(simple_Queue_Implementation.Dequeue());

            Console.WriteLine(Environment.NewLine + "BinarySearchTree" + Environment.NewLine);

            var tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            foreach (var item in tree.Preorder())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in tree.Post_Order())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();


            foreach (var item in tree.In_Order())
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

        }
    }
}
