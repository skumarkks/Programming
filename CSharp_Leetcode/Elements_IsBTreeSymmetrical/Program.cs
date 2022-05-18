using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_IsBTreeSymmetrical
{
    public class BtreeNode
    {
        public int data;
        public BtreeNode left;
        public BtreeNode right;

        public bool IsBTreeSymmetrical(BtreeNode root)
        {
            if (CheckSymeteric(root.left, root.right) == true)
                return true;
            return false;
        }

        private bool CheckSymeteric(BtreeNode rootLeft, BtreeNode rootRight)
        {
            // if both root of the subtree is null
            if (rootLeft == null && rootRight == null)
            {
                return true;
            }
            // if the data of the root of the left substree and root of the right subtree is equal,
            // and the check for the  
            else if (rootLeft != null && rootRight != null)
            {
                return (rootRight.data == rootLeft.data) &&
                       CheckSymeteric(rootLeft.right, rootRight.left) &&
                       CheckSymeteric(rootLeft.left, rootRight.right);
            }

            return false;
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
            var root9 = node.Create(9);
            root8.right = root9;

            bool isSymmetrical = node.IsBTreeSymmetrical(root);
            Console.WriteLine(isSymmetrical);

            root = node.Create(1);
            root.data = 1;
            root2 = node.Create(2);
            root2.data = 2;
            root3 = node.Create(3);
            root3.data = 2;
            root5 = node.Create(5);
            root5.data = 5;
            root6 = node.Create(6);
            root6.data = 5;
            root8 = node.Create(8);
            root8.data = 8;
            var root10 = node.Create(8);
            root10.data = 8;

            root.left = root2;
            root.right = root3;
            root2.right = root5;
            root5.left = root8;
            root3.left = root6;
            root6.right = root10;

            isSymmetrical = node.IsBTreeSymmetrical(root);
            Console.WriteLine(isSymmetrical);

        }
    }
}
