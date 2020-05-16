using System;

namespace ValidateBst
{
    using System.Collections.Generic;
    public class Program
    {
        public static bool ValidateBst(BST tree)
        {
            // Write your code here.
            if (tree == null) return false;

            var queue = new Queue<BST>();
            BST parent = tree;
            queue.Enqueue(parent);
            bool isValidate = false;

            while (queue.Count != 0)
            {
                parent = queue.Dequeue();
                if (parent.left != null && parent.left.value < parent.value  && 
                    parent.right != null && parent.right.value >= parent.value )
                {
                    isValidate = true;
                }
                else
                {
                    return false;
                }
                if (parent.left != null)
                {
                    queue.Enqueue(parent.left);
                }
                if (parent.right != null)
                {
                    queue.Enqueue(parent.right);
                }
            }

            return isValidate;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }

        public static void Main(string[] args)
        {
            BST tree1 = new BST(10);
            BST tree1left = new BST(8);
            BST tree1right = new BST(12);
            tree1.left = tree1left;
            tree1.right = tree1right;
            tree1left.left = new BST(6);
            tree1left.right = new BST(9);
            tree1right.left = new BST(11);
            tree1right.right = new BST(15);
            tree1left.left.left = new BST(4);
            tree1left.left.right = new BST(7);

            var result = Program.ValidateBst(tree1);

        }
    }

}
