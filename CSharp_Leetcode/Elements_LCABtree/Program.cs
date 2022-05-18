using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_LCABtree
{

    public class BtreeNode
    {
        public int data;
        public BtreeNode left;
        public BtreeNode right;

        // find the LCA for p and q node
        public BtreeNode LCABtree(BtreeNode root, BtreeNode p, BtreeNode q)
        {
            // if the root is null
            if (root == null)
            {
                return null;
            }
            // if the root is equal to either of p or q
            if (root == p || root == q)
            {
                return root;
            }
            
            // iterate through the node using inorder traversal
            BtreeNode left = LCABtree(root.left, p, q);
            BtreeNode right = LCABtree(root.right, p, q);

            // if the left node is not null and right node is not null then return root
            // else if left or right is null then return the other node

            if (left != null && right != null)
            {
                return root;
            }
            else
            {
                return left ?? right;
            }
        }

        public BtreeNode Create(int value)
        {
            var node = new BtreeNode
            {
                data = value,
                left = null,
                right = null
            };
            return node;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BtreeNode node = new BtreeNode();
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

            root.data = 1;
            root2.data = 2;
            root3.data = 3;
            root4.data = 4;
            root5.data = 5;
            root6.data = 6;
            root7.data = 7;
            root8.data = 8;

            BtreeNode noderesult = node.LCABtree(root, root2, root5);
            Console.WriteLine(noderesult.data);
        }
    }
}
