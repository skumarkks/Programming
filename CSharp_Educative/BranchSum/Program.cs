using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchSum
{
    class Program
    {

        public class BinaryTree
        {
            public int val;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.val = value;
                this.left = null;
                this.right = null;

            }

            public List<int> BranchSum(BinaryTree root)
            {
                List<int> currentBranchSum = new List<int>();
                BranchSum(root, 0, currentBranchSum);
                return currentBranchSum;
            }

            private void BranchSum(BinaryTree node, int sum, List<int> currentBranchSum)
            {
                if (node == null) return;
                
                if (node.left == null && node.right == null)
                {
                    sum = sum + node.val;
                    currentBranchSum.Add(sum);
                }

                BranchSum(node.left, sum+node.val, currentBranchSum);
                BranchSum(node.right, sum+node.val, currentBranchSum);
                
            }
        }

        static void Main(string[] args)
        {
            var root = new BinaryTree(1);
            var node2 = root.left = new BinaryTree(2);
            var node3 = root.right = new BinaryTree(3);
            var node4 = node2.left = new BinaryTree(4);
            var node5 = node2.right = new BinaryTree(5);
            var node6 = node3.left = new BinaryTree(6);
            var node7 = node3.right = new BinaryTree(7);
            var node8 = node4.left = new BinaryTree(8);
            var node9 = node4.right = new BinaryTree(9);
            var node10 = node5.left = new BinaryTree(10);

            var results = root.BranchSum(root);

            foreach(var result in results)
            { 
                Console.WriteLine(result);
            }



        }
    }
}
