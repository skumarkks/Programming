using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneGraph
{
    class Program
    {
        public class Node
        {
            public int val;
            public List<Node> neighbours;
            public Node(int Value, Node Neighbours)
            {
                val = Value;
                neighbours = new List<Node>();
                if(Neighbours != null)
                    neighbours.Add(Neighbours);
            }
        }

        public Node CloneGraph(Node node)
        {
            if (node == null)
                return null;

            Node copy = null;
            var oldToNew = new Dictionary<Node, Node>();
            var visited = new HashSet<Node>();

            var queue = new Queue<Node>();
            queue.Enqueue(node);
            
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                copy = new Node(temp.val, null);
                oldToNew[temp] = copy;
                visited.Add(temp);

                foreach (var nei in temp.neighbours)
                {
                    if (visited.Contains(nei))
                    {
                        copy.neighbours.Add(oldToNew[nei]);
                    }
                    else
                    {
                        var copyNei = new Node(nei.val, null);
                        copy.neighbours.Add(copyNei);
                        oldToNew[nei] = copyNei;
                        queue.Enqueue(nei);
                    }
                }
            }

            return copy;
        }

        static void Main(string[] args)
        {
            var node2 = new Node(2, null);
            var node4 = new Node(4, null);
            var node1 = new Node(1, null);
            var node3 = new Node(3, null);


            node2.neighbours = new List<Node>();
            node2.neighbours.Add(node4);
            node2.neighbours.Add(node1);

            node1.neighbours = new List<Node>();
            node1.neighbours.Add(node3);
            node1.neighbours.Add(node2);

            node4.neighbours = new List<Node>();
            node4.neighbours.Add(node2);
            node4.neighbours.Add(node3);

            node3.neighbours = new List<Node>();
            node3.neighbours.Add(node1);
            node3.neighbours.Add(node4);

            var prg = new Program();
            var result = prg.CloneGraph(node1);
        }
    }
}
