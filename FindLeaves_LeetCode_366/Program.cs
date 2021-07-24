using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLeaves_LeetCode_366
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public List<List<int>> heightLeaves;

        public int FindHeights(TreeNode root)
        {
            if (root == null)
                return -1;

            int leftHeight = FindHeights(root.left);
            int rightHeight = FindHeights(root.right);

            int currentHeight = 1 + Math.Max(leftHeight, rightHeight);

            if(heightLeaves.Count == currentHeight)
            {
                heightLeaves.Add(new List<int>());
            }

            heightLeaves[currentHeight].Add(root.val);

            return currentHeight;
        }

        public List<List<int>> FindLeaves(TreeNode root)
        {
            this.heightLeaves = new List<List<int>>();
            FindHeights(root);
            return this.heightLeaves;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(1, null, null);
            TreeNode node2 = new TreeNode(2, null, null);
            TreeNode node3 = new TreeNode(3, null, null);
            TreeNode node4 = new TreeNode(4, null, null);
            TreeNode node5 = new TreeNode(5, null, null);

            node1.left = node2;
            node1.right = node3;

            node2.left = node4;
            node2.right = node5;

            var sol = new Solution();
            var result = sol.FindLeaves(node1);





        }
    }
}
