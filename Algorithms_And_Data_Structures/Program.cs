using Algorithms_And_Data_Structures.Binary_search_tree;
using Algorithms_And_Data_Structures.Graph;
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

            var v0 = new Vertex(0);
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);

            Matrix matrix = new Matrix();
            matrix.Add_Vertex(v0);
            matrix.Add_Vertex(v1);
            matrix.Add_Vertex(v2);
            matrix.Add_Vertex(v3);
            matrix.Add_Vertex(v4);
            matrix.Add_Vertex(v5);

            matrix.Add_Edge(v0, v1);
            matrix.Add_Edge(v0, v2);
            matrix.Add_Edge(v1, v2);
            matrix.Add_Edge(v1, v3);
            matrix.Add_Edge(v2, v0);
            matrix.Add_Edge(v2, v3);
            matrix.Add_Edge(v3, v1);

            Console.WriteLine(Environment.NewLine + "Graph search in width" + Environment.NewLine);

            Graphs graph = new Graphs(matrix.Get_Matrix());
            foreach (var item in graph.BFS())
            {
                Console.WriteLine(item + ", ");
            }

            Console.WriteLine(Environment.NewLine + "Graph search in depth" + Environment.NewLine);

            matrix.Add_Edge(v0, v1);
            matrix.Add_Edge(v0, v4);
            matrix.Add_Edge(v1, v0);
            matrix.Add_Edge(v1, v2);
            matrix.Add_Edge(v1, v3);
            matrix.Add_Edge(v2, v1);
            matrix.Add_Edge(v2, v4);
            matrix.Add_Edge(v3, v1);
            matrix.Add_Edge(v3, v4);
            matrix.Add_Edge(v4, v0);
            matrix.Add_Edge(v4, v2);
            matrix.Add_Edge(v4, v3);

            graph = new Graphs(matrix.Get_Matrix());
            foreach (var item in graph.DFS())
            {
                Console.WriteLine(item + ", ");
            }

            Console.WriteLine(Environment.NewLine + "Graph Dijkstra's algorithm" + Environment.NewLine);

            matrix.Add_Edge(v0, v1, 5);
            matrix.Add_Edge(v0, v2, -1);
            matrix.Add_Edge(v0, v3, 6);
            matrix.Add_Edge(v0, v4, -1);
            matrix.Add_Edge(v0, v5, 50);
            matrix.Add_Edge(v1, v0, 5);
            matrix.Add_Edge(v1, v2, 7);
            matrix.Add_Edge(v1, v3, -1);
            matrix.Add_Edge(v1, v4, -1);
            matrix.Add_Edge(v1, v5, -1);
            matrix.Add_Edge(v2, v0, -1);
            matrix.Add_Edge(v2, v1, 7);
            matrix.Add_Edge(v2, v3, 4);
            matrix.Add_Edge(v2, v4, -1);
            matrix.Add_Edge(v2, v5, 10);
            matrix.Add_Edge(v3, v0, 6);
            matrix.Add_Edge(v3, v1, -1);
            matrix.Add_Edge(v3, v2, 4);
            matrix.Add_Edge(v3, v4, 10);
            matrix.Add_Edge(v3, v5, -1);
            matrix.Add_Edge(v4, v0, -1);
            matrix.Add_Edge(v4, v1, -1);
            matrix.Add_Edge(v4, v2, -1);
            matrix.Add_Edge(v4, v3, 10);
            matrix.Add_Edge(v4, v5, 8);
            matrix.Add_Edge(v5, v0, 50);
            matrix.Add_Edge(v5, v1, -1);
            matrix.Add_Edge(v5, v2, -10);
            matrix.Add_Edge(v5, v3, -1);
            matrix.Add_Edge(v5, v4, 8);

            graph = new Graphs(matrix.Get_Matrix());

            foreach (var item in graph.Dijkstra())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine + "Graph Floyd Warshell algorithm" + Environment.NewLine);

            matrix.Add_Vertex(v0);
            matrix.Add_Vertex(v1);
            matrix.Add_Vertex(v2);
            matrix.Add_Vertex(v3);
            matrix.Add_Vertex(v4);
            matrix.Add_Vertex(v5);

            matrix.Add_Edge(v0, v1, 5);
            matrix.Add_Edge(v0, v3, 6);
            matrix.Add_Edge(v0, v5, 50);
            matrix.Add_Edge(v1, v0, 5);
            matrix.Add_Edge(v1, v2, 7);
            matrix.Add_Edge(v2, v1, 7);
            matrix.Add_Edge(v2, v3, 4);
            matrix.Add_Edge(v2, v5, 10);
            matrix.Add_Edge(v3, v0, 6);
            matrix.Add_Edge(v3, v2, 4);
            matrix.Add_Edge(v3, v4, 10);
            matrix.Add_Edge(v4, v3, 10);
            matrix.Add_Edge(v5, v0, 50);
            matrix.Add_Edge(v5, v2, 10);
            matrix.Add_Edge(v5, v3, 8);

            graph = new Graphs(matrix.Get_Matrix());

            double[,] d = graph.Floyd_Warshell();
            Console.WriteLine(d[0, 5]);
        }
    }
}
