using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosGrafico.Source
{
    class Graph
    {
        private Dictionary<int, List<int>> adjList;
        private bool bIsDirected;

        public Graph()
        {
            adjList = new Dictionary<int, List<int>>();
            bIsDirected = false;
        }

        public Graph(bool bIsDirected)
        {
            adjList = new Dictionary<int, List<int>>();
            this.bIsDirected = bIsDirected;
        }

        public bool AddVertex(int vertex)
        {
            if(!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();
                return true;
            }
            return false;
        }

        public bool AddEdge(int source, int destination)
        {
            if (adjList.ContainsKey(source) && adjList.ContainsKey(destination))
            {
                adjList[source].Add(destination);
                if (!bIsDirected)
                    adjList[destination].Add(source);
                return true;
            }
            return false;
        }

        public bool RemoveEdge(int source, int destination)
        {
            if (adjList.ContainsKey(source) && adjList.ContainsKey(destination))
            {
                adjList[source].Remove(destination);
                if (!bIsDirected)
                    adjList[destination].Remove(source);
                return true;
            }
            return false;
        }

        public bool RemoveVertex(int vertex)
        {
            if(adjList.ContainsKey(vertex))
            {
                if(!bIsDirected)
                {
                    foreach (var otherVertex in adjList[vertex])
                    {
                        adjList[otherVertex].Remove(vertex);
                    }
                }
                else
                {
                    foreach (var key in adjList.Keys)
                    {
                        adjList[key].Remove(vertex);
                    }
                }

                adjList.Remove(vertex);
                return true;
            }
            return false;
        }

        public void PrintGraph()
        {
            foreach(var data in adjList)
            {
                Console.Write(data.Key + " -> [ ");
                foreach(var vertex in data.Value)
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine("]");
            }
        }

        public bool BFS(int start)
        {
            if (!adjList.ContainsKey(start)) return false;

            Queue<int> myQueue = new Queue<int>();
            List<int> visited = new List<int>();
            myQueue.Enqueue(start);
            visited.Add(start);

            Console.Write("BFS: ");

            while(myQueue.Any())
            {
                int currentVertex = myQueue.Dequeue();
                Console.Write(currentVertex + " ");

                foreach (int otherVertex in adjList[currentVertex])
                {
                    if(!visited.Contains(otherVertex))
                    {
                        myQueue.Enqueue(otherVertex);
                        visited.Add(otherVertex);
                    }
                }
            }
            Console.WriteLine();
            return true;
        }

        public bool BFS()
        {
            if (adjList.Any())
            {
                return BFS(adjList.Keys.First());
            }
            return false;
        }

        public bool DFS(int start)
        {
            if (!adjList.ContainsKey(start)) return false;

            Stack<int> myStack = new Stack<int>();
            List<int> visited = new List<int>();

            myStack.Push(start);
            visited.Add(start);

            Console.Write("DFS: ");

            while (myStack.Any())
            {
                int currentVertex = myStack.Pop();
                Console.Write(currentVertex + " ");

                foreach (int otherVertex in adjList[currentVertex])
                {
                    if (!visited.Contains(otherVertex))
                    {
                        myStack.Push(otherVertex);
                        visited.Add(otherVertex);
                    }
                }
            }

            Console.WriteLine();
            return true;
        }

        public bool DFS()
        {
            if (adjList.Any())
            {
                return DFS(adjList.Keys.First());
            }
            return false;
        }

        public int VertexCount()
        {
            return adjList.Count;
        }

        public List<int> GetVertices()
        {
            return adjList.Keys.ToList();
        }

        public Dictionary<int, List<int>> GetAdjList()
        {
            return adjList;
        }

        public bool IsDirected()
        {
            return bIsDirected;
        }
    }
}
