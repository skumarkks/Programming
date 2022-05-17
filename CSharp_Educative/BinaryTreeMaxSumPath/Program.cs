using System;

namespace BinaryTreeMaxSumPath
{
    public class Node
    {
        public int data;
        public Node lChild;
        public Node rChild;
    }
       


    class Program
    {
        public Node CreateBtree()
        {
            var root = new Node();

            var node1 = new Node();
            node1.data = 15;
            node1.lChild = null;
            node1.rChild = null;

            var node2 = new Node();
            node2.data = 7;
            node2.lChild = null;
            node2.rChild = null;


            root.data = -10;
            root.lChild = new Node();
            root.lChild.data = 9;
            root.lChild.lChild = null;
            root.lChild.rChild = null;

            root.rChild = new Node();
            root.rChild.data = 20;
            root.rChild.lChild = node1;
            root.rChild.rChild = node2;

            return root;
        }
        public int maxSum = Int32.MinValue;

        public int FindMaxPathSum(Node p)
        {

            if (p == null) return 0;

            int leftValue = FindMaxPathSum(p.lChild);
            int rightValue = FindMaxPathSum(p.rChild);

            int newRootSum = p.data + leftValue + rightValue;

            maxSum = Math.Max(maxSum,newRootSum);

            return p.data + leftValue + rightValue;
        }

        static void Main(string[] args)
        {
            int maxSum = Int32.MinValue;

            var prg = new Program();
            var root = prg.CreateBtree();

            prg.FindMaxPathSum(root);

            Console.WriteLine("BinaryTreeMaxSumPath {0}",prg.maxSum);
            Console.WriteLine("Hello World!");
        }
    }
}
