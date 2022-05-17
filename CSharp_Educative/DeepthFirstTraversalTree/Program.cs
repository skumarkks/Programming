using System;
using System.Collections.Generic;

namespace DeepthFirstTraversalTree
{
    public class Node
    {
        public string val;
        public List<Node> nodes;
        public Node(string val)
        {
            this.val = val;
            this.nodes = null;            
        }
    }

    public class Tree
    {
        public Node root;
        public Node CreateTree()
        {
            var queue = new Queue<Node>();
            Console.Write("Enter value for Root: ");
            var val = Console.ReadLine();
            root = new Node(val);

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node temp = queue.Dequeue();

                
                while (val != "-1")
                {
                    Console.Write("Enter the childrens for {0} or -1 ", temp.val);
                    val = Console.ReadLine();

                    if (val != "-1")
                    {
                        var temp1 = new Node(val);

                        if (temp.nodes == null)
                        {
                            temp.nodes = new List<Node>();
                        }

                        temp.nodes.Add(temp1);
                        queue.Enqueue(temp1);
                    }
                }
                val = "0";
            }
            return root;
        }

        public void DFS(Node p, List<string> searchResult)
        {
            if (p == null) return;
            if (p != null)
            {
                searchResult.Add(p.val);
                int i = 0;
                while(p.nodes != null && i < p.nodes.Count)
                {
                    var node = p.nodes[i];
                    DFS(node, searchResult);
                    i++;
                }
            }
        }

        

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Tree();
            var root = test.CreateTree();
            var search = new List<string>();
            test.DFS(root, search);
            Console.WriteLine();
            foreach (var item in search)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
