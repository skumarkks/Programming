using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_SumOfLeafNodes
{
    public class BtreeNode
    {
        public int data;
        public BtreeNode left;
        public BtreeNode right;
        public Stack<int> stack = new Stack<int>();
        private int sum = 0;
        public void pathOfGivenSumTree(BtreeNode root, int k)
        {
            if (root == null)
                return;
            sum = sum + root.data;
            stack.Push(root.data);
            if (sum == k)
            {
                while (stack.Count != 0)
                    Console.WriteLine(stack.Pop());
                return;
            }

            pathOfGivenSumTree(root.left, k);
            pathOfGivenSumTree(root.right, k);
            sum = sum - root.data;
            if (stack.Count != 0)
            {
                stack.Pop();
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

            node.pathOfGivenSumTree(root, 10);
        }
    }
}
