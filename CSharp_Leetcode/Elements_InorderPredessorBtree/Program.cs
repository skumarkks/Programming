using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_InorderPredessorBtree
{
    public class BtreeNode
    {
        public int key;
        public BtreeNode left;
        public BtreeNode right;

        public BtreeNode FindNodeByValue(BtreeNode root, int key)
        {
            while (root.key != key)
            {
                if (root.left.key < key)
                {
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }

            return root;
        }

        public BtreeNode InOrderPredessor(BtreeNode KeyRoot, BtreeNode root, int Key)
        {
            BtreeNode keyNode = KeyRoot;
            BtreeNode rootNode = root;

            if(KeyRoot == null)
            {
                return null;
            }
            // if the left node of the keynode is not null go to the left child and then go to the right node till the end of the left child node.
            if (keyNode.left != null)
            {
                keyNode = keyNode.left;
                while (keyNode.right != null)
                {
                    keyNode = keyNode.right;
                }
                return keyNode;
            }

            if (keyNode.left == null)
            {
                BtreeNode store = null;
                while (keyNode.key != rootNode.key)
                {
                    if (rootNode.key < keyNode.key)
                    {
                        store = rootNode;
                        rootNode = rootNode.right;
                    }
                    else
                    {
                        rootNode = rootNode.left;
                    }
                }

                return store;
            }

            return null;
        }

        public BtreeNode Create(int value)
        {
            var node = new BtreeNode
            {
                key = value,
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

            root.key = 50;
            root2.key = 16;
            root3.key = 90;
            root4.key = 14;
            root5.key = 40;
            root6.key = 78;
            root7.key = 100;
            root8.key = 10;

           BtreeNode node1 = node.InOrderPredessor(root2, root, 16);
           Console.WriteLine(node1.key);

        }
    }
}
