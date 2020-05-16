using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;

namespace TwoSum_BinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int Value)
        {
            this.val = Value;
            this.left = null;
            this.right = null;
        }
    }

    class Program
    {
        public static bool FindTargetByInorderSearch(TreeNode root, int k)
        {
            List<int> inOrderList = new List<int>();

            FindInorder(root, inOrderList);

            int left = 0;
            int right = inOrderList.Count - 1;

            while (left < right)
            {
                int sum = inOrderList[left] + inOrderList[right];

                if (sum == k)
                {
                    return true;
                }
                else if(sum < k)
                {
                    left++;
                }
                else if (sum > k)
                {
                    right--;
                }
            }

            return false;
        }

        private static void FindInorder(TreeNode root, List<int> inOrderList)
        {
            FindInorder(root.left,inOrderList);
            inOrderList.Add(root.val);
            FindInorder(root.right,inOrderList);
        }

        public static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            return Find(root, k, set);
        }

        private static bool Find(TreeNode root, int k, HashSet<int> set)
        {
            if (root == null)
                return false;
            int dif = k - root.val;
            if (set.Contains(dif))
            {
                return true;
            }

            set.Add(root.val);

            return Find(root.left, k, set) || Find(root.right, k, set);
        }

        static void Main(string[] args)
        {
            TreeNode tree1 = new TreeNode(2);
            TreeNode tree2 = new TreeNode(0);
            TreeNode tree3 = new TreeNode(3);

            tree1.left = tree2;
            tree1.right = tree3;

            TreeNode tree4 = new TreeNode(-4);
            TreeNode tree5 = new TreeNode(1);

            tree2.left = tree4;
            tree2.right = tree5;

            bool result = Program.FindTarget(tree1, -1);


        }
    }

    
}
