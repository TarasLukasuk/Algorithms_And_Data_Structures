namespace Algorithms_And_Data_Structures.Graph
{
    internal class Matrix
    {
        List<Vertex> Vertex = new List<Vertex>();
        List<Edge> Edge = new List<Edge>();

        public void Add_Vertex(Vertex vertex)
        {
            Vertex.Add(vertex);
        }


        public void Add_Edge(Vertex from, Vertex to)
        {
            var edge =new Edge(from, to);
            Edge.Add(edge);
        }

        public void Add_Edge(Vertex from, Vertex to, int weight)
        {
            var edge = new Edge(from, to, weight);
            Edge.Add(edge);
        }


        public int[,] Get_Matrix()
        {
            var matrix=new int[Vertex.Count, Vertex.Count];

            try
            {
                foreach (var edge in Edge)
                {
                    var row = edge.From.Number - 1;
                    var column = edge.To.Number - 1;

                    matrix[row, column] = edge.Weight;
                }
            }
            catch (Exception)
            {
                foreach (var edge in Edge)
                {
                    var row = edge.From.Number;
                    var column = edge.To.Number;

                    matrix[row, column] = edge.Weight;
                }
            }
            return matrix;
        }
    }
}
