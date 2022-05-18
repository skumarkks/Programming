using System;
using System.Collections.Generic;

namespace _53_LeetCode_MaxSubArray
{
    public class Solution
    {
        private static int maxSum = Int32.MinValue;
        public int MaxSubArray(int[] nums)
        {
            //handle corner cases
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];

            List<int> combination = new List<int>();
            List<List<int>> candidates = new List<List<int>>();
            int sum = Int32.MinValue;
            FindMaxSum(0, 0, combination, candidates, nums, sum);
            return maxSum;

        }

        public void FindMaxSum(int startIndex, int currentIndex, List<int> combination, List<List<int>> candidates, int[] nums, int sum)
        {
            if (startIndex > nums.Length)
                return;

           if (maxSum < sum)
            {
                maxSum = sum;
                candidates.Add(combination);
            }

            for (int i = startIndex, j = i; i < nums.Length; i++)
            {
                combination.Add(nums[j]);
                FindMaxSum(i, j+1, combination, candidates, nums, sum + nums[j]);
                combination.RemoveAt(combination.Count-1);
            }
        }
    }
    class Program
    {

        public static int maxSubArray(int[] A)
        {
            int maxSoFar = A[0], maxEndingHere = A[0];
            for (int i = 1; i < A.Length; ++i)
            {
                maxEndingHere = Math.Max(maxEndingHere + A[i], A[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }

        static void Main(string[] args)
        {
            int[] A = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int max = maxSubArray(A);
        }
    }
}
