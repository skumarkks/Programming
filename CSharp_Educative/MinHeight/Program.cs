using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeight
{
    public class BST
    {
        public BST left;
        public BST right;
        public int value;

        public BST(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public static BST MinHeight(int[] array)
        {
            return MinHeight(array, null, 0, array.Length - 1);
        }

        public static BST MinHeight(int[] array, BST node, int startIdx, int EndIdx)
        {
            if (EndIdx < startIdx)
                return null;

            int mid = (startIdx + EndIdx) / 2;
            int value = array[mid];

            if (node == null)
            {
                node = new BST(value);
            }
            else
            {
                node.Insert(value);
            }

            MinHeight(array, node, 0, mid - 1);
            MinHeight(array, node, mid + 1, EndIdx);

            return node;
        }

        private void Insert(int value)
        {
            if (value < this.value)
            {
                if (this.left == null)
                {
                    this.left = new BST(value);
                }
                else
                {
                    this.left.Insert(value);
                }
            }
            else if (value >= this.value)
            {
                if (this.right == null)
                {
                    this.right = new BST(value);
                }
                else
                {
                    this.right.Insert(value);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 5, 7, 10, 13, 14, 15, 22};
            BST root = BST.MinHeight(nums);

        }
    }
}
