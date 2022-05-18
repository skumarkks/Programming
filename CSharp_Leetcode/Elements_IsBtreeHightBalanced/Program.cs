using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IsBtreeHightBalanced
{
    // The definition of height balanced tree is if the height of a node is 0 or 1
    // if the node have a height -1 or greater then 1 then the treee is not heigh balanced.
    public class BTreeNode
    {
        public int key;
        public BTreeNode left;
        public BTreeNode right;

        public bool IsHightBalanced(BTreeNode root)
        {
            if (BtreeHightNode(root) > -1)
                return true;
            return false;
        }

        public int BtreeHightNode(BTreeNode root)
        {
            // if the node is null then reurn 0
            if (root == null)
                return 0;

            // recursively call BtreeHightNode
            int h1 = BtreeHightNode(root.left);
            int h2 = BtreeHightNode(root.right);

            // If the height is -1 return -1, this can happen 
            //         1
            //         /\
            //        2  3
            //             \
            //              4

            if (h1 == -1 || h2 == -1)
            {
                return -1;
            }

            if (Math.Abs(h1 - h2) > 1)
            {
                return -1;
            }

            if (h1 > h2)
            {
                return h1 + 1;
            }
            return h2 + 1;
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
            var root9 = node.Create(9);
            root8.right = root9;

            bool isBalanced = node.IsHightBalanced(root);
            Console.WriteLine(isBalanced);
        }
    }
}
