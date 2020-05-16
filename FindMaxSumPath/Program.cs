using System;
using System.Collections.Generic;

namespace FindMaxSumPath
{
    public class Node
    {
        public int data;
        public Node lchild;
        public Node rchild;

        public Node(int val)
        {
            data = val;
            lchild = null;
            rchild = null;
        }
    }
    class Program
    {
        public static int maxSum = Int32.MinValue;

        public int FindMxSumPathCalculation(Node p, int sum)
        {
            if(p == null)
            {
                maxSum = Math.Max(maxSum, sum);
                return maxSum;
            }

            FindMxSumPathCalculation(p.lchild, sum + p.data);
            FindMxSumPathCalculation(p.rchild, sum + p.data);

            return maxSum;

        }

        public static List<int> result = new List<int>();
        
        public static List<int> BranchSum(Node root, int sum)
        {
            if (root.lchild == null && root.rchild == null)
            {
                result.Add(sum);
                return result;
            }

            if(root.lchild != null)
                BranchSum(root.lchild, sum + root.lchild.data);
            if(root.rchild != null)
                BranchSum(root.rchild, sum + root.rchild.data);

            return result;
        }
        static void Main(string[] args)
        {
            Node p1 = new Node(1);
            Node p2 = new Node(2);
            Node p3 = new Node(3);
            Node p4 = new Node(4);
            Node p5 = new Node(5);
            Node p6 = new Node(6);
            Node p7 = new Node(7);

            p1.lchild = p2;
            //p1.rchild = p3;
            //p2.lchild = p4;
           // p2.rchild = p5;
            //p3.lchild = p6;
            //p3.rchild = p7;

            var test = new Program();
            //int maxSum = test.FindMxSumPathCalculation(p1, 0);

            var res = BranchSum(p1, p1.data);

            Console.WriteLine(maxSum);
        }
    }
}
