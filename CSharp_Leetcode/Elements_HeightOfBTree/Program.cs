using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_HeightOfBTree
{
    public class BTreeNode
    {
        public int key;
        public BTreeNode left;
        public BTreeNode right;

        public  int HeightBtree(BTreeNode root)
        {
            if (root == null)
                return 0;

            int left = HeightBtree(root.left);
            int right = HeightBtree(root.right);

            return Math.Max(left, right) + 1;
        }

        public BTreeNode Create(int value)
        {
            var node = new BTreeNode();
            node.key = value;
            node.left = null;
            node.right = null;
            return node;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BTreeNode node = new BTreeNode();
            var root = node.Create(1);
            var root2 = node.Create(2);
            var root3 = node.Create(3);
            root.left = root2;
            root.right = root3;
            var root4 = node.Create(4);
            var root5 = node.Create(5);
            root2.left = root4;
            root2.right = root5;
            var root6 = node.Create(6);
            var root7 = node.Create(7);
            root3.left = root6;
            root3.right = root7;
            var root8 = node.Create(8);
            root4.right = root8;

            int height = node.HeightBtree(root);
            Console.WriteLine(height);
        }
    }
}
