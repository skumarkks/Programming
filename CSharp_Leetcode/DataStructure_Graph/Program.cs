using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Graph
{


    public class edgeNode
    {
        public int y;
        public int weight;
        public edgeNode next;
    };

    public class Graph
    {
        private const int  MAXV = 1000;
        private edgeNode[] edges;
        int[] degree;
        int nVertices;
        int nDegree;
        int nEdges;
        bool directed;

        public void Initialize_Graph(Graph g, bool directed)
        {
            int i;
            g.nVertices = 0;
            g.nEdges = 0;
            g.directed = directed;
            g.edges = new edgeNode[MAXV];
            g.degree = new int[MAXV];

            for ( i = 0; i < MAXV; i++)
            {
                g.edges[i] = null;
            }

            for (i = 0; i < MAXV; i++)
            {
                g.degree[i] = 0;
            }
        }

        public void Read_Graph(Graph g, bool directed)
        {
            Initialize_Graph(g, directed);
            Console.WriteLine("Number of Vertices: ");
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of edges: ");
            int e = int.Parse(Console.ReadLine());

            for(int i = 1; i <= e; i++)
            {
                Console.WriteLine("Vertex for edge: ");
                int x = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Vertex for edge: ");
                int y = int.Parse(Console.ReadLine());

                insert_edge(g, x, y, directed);
            }
        }

        private void insert_edge(Graph g, int x, int y, bool directed)
        {
            edgeNode p = new edgeNode();
            p.y = y;
            p.weight = 0;
            p.next = g.edges[x];
            g.edges[x] = p;
            g.degree[x]++;
            if(directed)
            {
                insert_edge(g, y, x, false);
            }
            else
            {
                g.nEdges++;
            }
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            var g = new Graph();
            g.Read_Graph(g, false);
        }
    }
}
