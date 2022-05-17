using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightBinaryTree
{

    public class BinaryTree
    {
        public int val;
        public int height;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }

        public int Height(BinaryTree node)
        {
            if (node == null) return 0;

            int lHeight = Height(node.left);
            int rHeight = Height(node.right);

            int height = 1 + Math.Max(lHeight,rHeight);
            node.height = height;
            return height;
        }

        public void PreOrderTraversal(BinaryTree node, List<List<int>> nodeHeightVal)
        {
            if(node != null)
            {
                List<int> list = new List<int>();
                list.Add(node.val);
                list.Add(node.height);
                nodeHeightVal.Add(list);
            }

            if (node.left != null) PreOrderTraversal(node.left, nodeHeightVal);
            if (node.right != null) PreOrderTraversal(node.right, nodeHeightVal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree node1 = new BinaryTree(10);
            BinaryTree node2 = new BinaryTree(5);
            BinaryTree node3 = new BinaryTree(6);
            BinaryTree node4 = new BinaryTree(8);
            BinaryTree node5 = new BinaryTree(7);
            BinaryTree node6 = new BinaryTree(4);

            node1.left = node2;
            node1.right = node3;
            node3.left = node4;
            node3.right = node5;
            node5.right = node6;

            int height = node1.Height(node1);

            List<List<int>> nodeHeightVal = new List<List<int>>();
            node1.PreOrderTraversal(node1, nodeHeightVal);

            foreach (var node in nodeHeightVal)
            {
                Console.WriteLine("{0} {1}", node[0], node[1]);
            }
            Console.Read();
        }
    }
}
