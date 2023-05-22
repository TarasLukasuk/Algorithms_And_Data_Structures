namespace Algorithms_And_Data_Structures.Binary_search_tree
{
    internal class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Preorder(Root);
        }

        public List<T> Post_Order()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Post_Order(Root);
        }

        public List<T> In_Order()
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return In_Order(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }

        private List<T> Post_Order(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Post_Order(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Post_Order(node.Right));
                }

                list.Add(node.Data);
            }
            return list;
        }

        private List<T> In_Order(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(In_Order(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(In_Order(node.Right));
                }
            }
            return list;
        }
    }
}
