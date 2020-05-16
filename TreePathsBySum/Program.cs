using System;
using System.Collections.Generic;

namespace TreePathsBySum
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

    public class Tree
    {
        public void FindTreePathBySum(Node p, int target, List<int> path, List<IList<int>> paths)
        {
            if (p == null) return;

            path.Add(p.data);

            if (p.data == target && p.lchild == null && p.rchild == null)
            {
                var tempPath = new List<int>(path);                
                paths.Add(tempPath);                
                return;
            }
            
            FindTreePathBySum(p.lchild, target - p.data, path, paths);
            // you need path to be removed since it is a reference variable
            if(p.lchild != null)
                path.Remove(p.lchild.data);
            FindTreePathBySum(p.rchild, target - p.data, path, paths);
            if(p.rchild != null)
                path.Remove(p.rchild.data);

            return;
        }

        //Time O(n) and Space O(log n)
        public void FindSumofPaths(Node p,  int sum, ref int sums)
        {
            if (p == null) return;

            sum = 10 * sum + p.data;

            if (p.lchild == null && p.rchild == null)
            {
                sums += sum; 
                return;
            }            

            FindSumofPaths(p.lchild, sum, ref sums);
            //You dont need the following code since sum is a stack based variable
            //if(p.lchild != null)
            //    sum -= p.lchild.data;
            FindSumofPaths(p.rchild, sum, ref sums);
            //if(p.rchild != null)
            //    sum -= p.rchild.data;

            return;

        }


    }

    public class Test
    {
        public static void Main(string[] agrs)
        {

            var root = new Node(1);
            var node2 = root.lchild = new Node(7);
            var node3 = root.rchild = new Node(9);

            var node4 = node2.lchild = new Node(4);
            var node5 = node2.rchild = new Node(5);

            var node6 = node3.lchild = new Node(2);
            var node7 = node3.rchild = new Node(7);

            var test = new Tree();
            var path = new List<int>();
            var paths = new List<IList<int>>();

            test.FindTreePathBySum(root, 12, path, paths);

            foreach (var item in paths)
            {
                foreach (var i in item)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            int sum = 0;
            int sums = 0;
      
            test.FindSumofPaths(root, sum, ref sums);

        }
    }

}
