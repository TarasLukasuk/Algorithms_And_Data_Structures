using System;
using System.Data;

namespace Algorithms_And_Data_Structures.Graph
{
    internal class Graphs
    {
        private int[,] List_Of_Vertices;
        private readonly int Number_Of_Vertices;

        public Graphs(int[,] arr)
        {
            List_Of_Vertices = arr;
            Number_Of_Vertices = arr.GetLength(0);
        }


        public List<int> BFS(int starting_Position = 1)
        {
            bool[] visited = new bool[Number_Of_Vertices];
            Queue<int> queue = new Queue<int>();
            List<int> result = new List<int>();
            queue.Enqueue(starting_Position);
            visited[starting_Position] = true;

            while (queue.Count != 0)
            {
                int index = queue.Dequeue();
                result.Add(index);

                for (int i = 0; i < Number_Of_Vertices; i++)
                {
                    if (List_Of_Vertices[index, i] != 0 && !visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
            return result;
        }

        public List<int> DFS(int starting_Position = 0)
        {
            bool[] visited = new bool[Number_Of_Vertices];
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();
            stack.Push(starting_Position);
            visited[starting_Position] = true;

            while (stack.Count != 0)
            {
                int index = stack.Pop();
                result.Add(index);

                for (int i = 0; i < Number_Of_Vertices; i++)
                {
                    if (!visited[i] && List_Of_Vertices[index, i] != 0)
                    {
                        stack.Push(i);
                        visited[i] = true;
                    }
                }
            }
            return result;
        }


        public List<double> Dijkstra(int starting_Position = 0)
        {
            const int INDEX_STARTING_POSITION = -1;

            List<double> distance = new List<double>();
            bool[] visited = new bool[Number_Of_Vertices];

            for (int i = 0; i < Number_Of_Vertices; i++)
            {
                distance.Add(double.MaxValue);
                visited[i] = false;
            }

            distance[starting_Position] = 0;
            int index = INDEX_STARTING_POSITION;
            for (int i = 0; i < Number_Of_Vertices; i++)
            {
                double min_Value = double.MaxValue;
                for (int j = 0; j < Number_Of_Vertices; j++)
                {
                    if (!visited[j] && distance[j] <= min_Value)
                    {
                        min_Value = distance[j];
                        index = j;
                    }
                }

                visited[index] = true;
                for (int j = 0; j < Number_Of_Vertices; j++)
                {
                    if (!visited[j] && List_Of_Vertices[index, j] > INDEX_STARTING_POSITION && distance[index] != double.MaxValue && distance[index] + List_Of_Vertices[index, j] < distance[j])
                    {
                        distance[j] = distance[index] + List_Of_Vertices[index, j];
                    }
                }
            }

            return distance;
        }


        public double[,] Floyd_Warshell()
        {
            double[,] distances = new double[Number_Of_Vertices, Number_Of_Vertices];
            for (int i = 0; i < Number_Of_Vertices; i++)
            {
                for (int j = 0; j < Number_Of_Vertices; j++)
                {
                    distances[i, j] = List_Of_Vertices[i, j];
                }
            }

            for (int k = 0; k < Number_Of_Vertices; k++)
            {
                for (int i = 0; i < Number_Of_Vertices; i++)
                {
                    for (int j = 0; j < Number_Of_Vertices; j++)
                    {
                        if (distances[i, k] != 0 && distances[k, j] != 0 && i != j)
                        {
                            if (distances[i, k] + distances[k, j] < distances[i, j] || distances[i, j] == 0)
                            {
                                distances[i, j] = distances[i, k] + distances[k, j];
                            }
                        }
                    }
                }
            }

            return distances;
        }
    }
}
