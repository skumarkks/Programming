using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeDeepth
{
    public class Program
    {
        public class Level
        {
            public int deepth;
            public BinaryTree node;

            public Level(int dth, BinaryTree cNode)
            {
                deepth = dth;
                node = cNode;
            }
        }

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

            public int SumNodeDeepth(BinaryTree bst)
            {
                if (bst == null) return 0;
                if (bst.left == null && bst.right == null) return 0;


                Stack<Level> stack = new Stack<Level>();
                stack.Push(new Level(0, bst));

                int totalDeepth = 0;

                while (stack.Count != 0)
                {
                    var lvl = stack.Pop();

                    totalDeepth += lvl.deepth;

                    if (lvl.node.left != null)
                    {
                        stack.Push(new Level(lvl.deepth+1, lvl.node.left));
                    }

                    if (lvl.node.right != null)
                    {
                        stack.Push(new Level(lvl.deepth + 1, lvl.node.right));
                    }
                }
                return totalDeepth;
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
            //var node10 = node5.left = new BinaryTree(10);

            int deepth = root.SumNodeDeepth(root);
            Console.WriteLine(deepth);
        }
    }
}
