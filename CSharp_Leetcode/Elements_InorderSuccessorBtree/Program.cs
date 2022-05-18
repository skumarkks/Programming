using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_InorderSuccessorBtree
{
    public class BtreeNode
    {
        public int data;
        public BtreeNode left;
        public BtreeNode right;

        public BtreeNode InorderSuccessor(BtreeNode root, BtreeNode keyNode, int value)
        {
            BtreeNode rootNode = root;
            BtreeNode key = keyNode;

            // if there exist a right subtree, go to the right child and travels through the left child to its minimum value
            if (key?.right != null)
            {
                BtreeNode temp = key.right;
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                return temp;

            }

            // if the right child is null, then travel from the root to the keynode 
            // the last left child visited will be the succesor 
            if (key.right == null)
            {
                if (rootNode != null)
                {
                    BtreeNode store = null;
                    while (rootNode.data != key.data)
                    {
                        if (rootNode.left != null || rootNode.right != null)
                        {
                            if (rootNode.data > key.data)
                            {
                                store = rootNode;
                                rootNode = rootNode.left;
                            }
                            else
                            {
                                rootNode = rootNode.right;
                            }
                        }
                    }
                    return store;
                }
            }

            return null;
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
            // this tree is not balanced
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
            root4.left = root8;

            root.data = 50;
            root2.data = 16;
            root3.data = 90;
            root4.data = 14;
            root5.data = 40;
            root6.data = 78;
            root7.data = 100;
            root8.data = 10;

            BtreeNode node1 = node.InorderSuccessor(root, root4, 14);
            Console.WriteLine(node1.data);
        }
    }
}
