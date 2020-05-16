using System;
using System.Collections.Generic;

namespace BinaryTreeInversion
{

    
    public class Program
    {
        public static void InvertBinaryTree(BinaryTree tree)
        {
            // Write your code here.
            
            if (tree == null) return;
            if (tree.left == null && tree.right == null) return;

            var queue = new Queue<BinaryTree>();
            BinaryTree parent = tree;

            queue.Enqueue(parent);
            while (queue.Count != 0)
            {
                parent = queue.Dequeue();
                if (parent.left != null)
                    queue.Enqueue(parent.left);
                if (parent.right != null)
                    queue.Enqueue(parent.right);

                if (parent.right != null || parent.left != null)
                {
                    BinaryTree temp = parent.right;
                    parent.right = parent.left;
                    parent.left = temp;
                }
            }
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree(1);
            BinaryTree tree1left = new BinaryTree(2);
            BinaryTree tree1right = new BinaryTree(3);
            tree1.left = tree1left;
            tree1.right = tree1right;
            tree1left.left = new BinaryTree(4);
            tree1left.right = new BinaryTree(5);
            tree1right.left = new BinaryTree(6);
            tree1right.right = new BinaryTree(7);
            tree1left.left.left = new BinaryTree(8);
            tree1left.left.right = new BinaryTree(9);

            Program.InvertBinaryTree(tree1);

            Console.WriteLine("Hello World!");
        }

    }


    
}
