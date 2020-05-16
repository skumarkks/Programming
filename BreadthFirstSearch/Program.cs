using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] g = new int[,] { { 0,0,0,0,0,0,0,0 },
                                    { 0,0,1,1,1,0,0,0 },
                                    { 0,1,0,1,0,0,0,0 },
                                    { 0,1,1,0,1,1,0,0 },
                                    { 0,1,0,1,0,1,0,0 },
                                    { 0,0,0,1,1,0,1,1 },
                                    { 0,0,0,0,0,1,0,0 },
                                    { 0,0,0,0,0,1,0,0 },
                                    { 0,0,0,0,0,1,0,0 }
                                  };


            // BFS(g, 1);
            int[] visited = new int[8];
            DFSRecursion(g, 1, visited);
            
        }

        //static int visited = new int[7];

        public static void DFSRecursion(int[,] g, int start, int[] visited)
        {
            //ong len = g.GetLength(0) - 1;
            //static int visited = new int[len];
            //int k = 0;
            //while (k < len) visited[k++] = 0;

            if(visited[start] == 0)
            {
                Console.Write("{0} ", start);
                visited[start] = 1;


                for (int j = 1; j < 8; j++)
                {                    
                    if (g[start, j] == 1 && visited[j] == 0)
                    {
                        //Console.Write(start);
                        //visited[start] = 1;
                        DFSRecursion(g, j, visited);
                        //Console.Write(start);
                    }
                    
                }
            }

        }

        private static void DFS(int[,] g, int start)
        {
            long len = g.GetLength(0) - 1;
            var stack = new Stack<int>();
            var visited = new int[len];
            int k = 0;
            while (k < len) visited[k++] = 0;

            stack.Push(start);

            while(stack.Count != 0)
            {
                int i = stack.Pop();
                Console.Write("{0} ", i);

                for (int j = 0; j < len; j ++)
                {

                    if(visited[j] == 0 && g[i,j] == 1)
                    {
                        visited[j] = 1;
                        stack.Push(j);
                    }
                }
            }


        }

        private static void BFS(int[,] g, int start)
        {
            long len = g.GetLongLength(0);
            var visited = new int[len];
            int k = 0;
            while (k < len) visited[k++] = 0;
            //var result = new List<int>();

            var queue = new Queue<int>();
            visited[start] = 1;
            queue.Enqueue(start);

            while(queue.Count != 0)
            {
                int node = queue.Dequeue();
                Console.Write("{0} ", node);
                int i = node;
                for (int j = 1; j < len-1; j++)
                {
                    if(g[i,j] == 1 && visited[j] == 0)
                    {
                        visited[j] = 1;
                        queue.Enqueue(j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
