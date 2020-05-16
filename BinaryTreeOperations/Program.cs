using System;
using System.Collections.Generic;

namespace BinaryTreeOperations
{
    public class Node
    {
        public int data;
        public Node lchild;
        public Node rchild;

        public Node(int val)
        {
            this.data = val;
            this.lchild = null;
            this.rchild = null;
        }
    }

    public class BinaryTree
    {
        
        public Node CreateBtree()
        {
            var root = new Node(1);
            var node1 = root.lchild = new Node(2);
            var node2 = root.rchild = new Node(3);

            node1.lchild = new Node(4);
            node1.rchild = new Node(5);

            node1.rchild.rchild = new Node(8);

            return root;
        }

        public int FindMinDeepth(Node root)
        {
            if (root == null) return 0;
            Node temp = root;
            var queue = new Queue<Node>();
            queue.Enqueue(temp);

            int ldeepth = 0;
            int rdeepth = 0;

            while(queue.Count != 0)
            {
                temp = queue.Dequeue();

                if (temp.lchild != null)
                {
                    ldeepth += 1;
                    queue.Enqueue(temp.lchild);
                }
                else
                    return ldeepth;

                if (temp.rchild != null)
                {
                    rdeepth += 1;
                    queue.Enqueue(temp.rchild);
                }
                else
                    return rdeepth;
            }

            return Math.Min(ldeepth, rdeepth);
        }

        public int FindMaxDeepth(Node root)
        {
            if (root == null) return 0;
            Node temp = root;
            var queue = new Queue<Node>();
            queue.Enqueue(temp);

            int ldeepth = 0;
            int rdeepth = 0;

            while (queue.Count != 0)
            {
                temp = queue.Dequeue();

                if (temp.lchild != null)
                {
                    ldeepth += 1;
                    queue.Enqueue(temp.lchild);
                }
                
                if (temp.rchild != null)
                {
                    rdeepth += 1;
                    queue.Enqueue(temp.rchild);
                }
            }

            return Math.Max(ldeepth, rdeepth)+1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var test = new BinaryTree();

            var root = test.CreateBtree();

            int minDeepth =  test.FindMinDeepth(root);
            Console.WriteLine("Min Deepth: {0}", minDeepth);

            int maxDeepth = test.FindMaxDeepth(root);
            Console.WriteLine("Max Deepth: {0}", maxDeepth);


            Console.WriteLine("Hello World!");
        }
    }
}
