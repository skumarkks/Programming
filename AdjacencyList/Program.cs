using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyList
{
    public class AdjNode
    {
        public int source;
        public int destination;
        public int weight;
        internal AdjNode next;

        public AdjNode(int src, int dest, int wght)
        {
            source = src;
            destination = dest;
            weight = wght;
            next = null;
        }
    }

    public class edgeList
    {
        public AdjNode head;
    }

    public class Graph
    {
        public int vCount;
        public edgeList[] adjArray;

        public Graph(int count)
        {
            vCount = count;
            adjArray = new edgeList[count];
            for (int i = 0; i < count; i++)
            {
                adjArray[i] = new edgeList();
                adjArray[i].head = null;
            }
        }

        public void AddEdge(int src, int dest, int wght)
        {
            AdjNode node = new AdjNode(src, dest, wght);
            node.next = adjArray[src].head;
            adjArray[src].head = node;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(8);
            g.AddEdge(0, 1, 1);
            g.AddEdge(0, 2, 2);
            g.AddEdge(0, 3, 3);
            g.AddEdge(1, 4, 4);
            g.AddEdge(2, 5, 5);
            g.AddEdge(3, 6, 6);
            g.AddEdge(4, 7, 7);
            g.AddEdge(5, 7, 7);
            g.AddEdge(6, 7, 7);
        }
    }
}
