using System;

namespace MaximumSumircularArray
{
    public class MaximumSumSubArray
    {
        int FindMaximumSumSubArray(int[] nums, out int[] result)
        {
            if (nums.Length == 0)
            {
                result = new int[] { -1, -1 };
                return 0;
            }

            int maxSumSoFar = nums[0];
            int maxSum = Int32.MinValue;

            int start = 0;
            int end = 0;
            int lastSum;
            int lastMax;

            for (int i = 0; i < nums.Length; i++)
            {

                maxSumSoFar = Math.Max(maxSumSoFar + nums[i], nums[i]);
                if (maxSumSoFar == nums[i])
                {
                    start = i;
                }

                lastMax = maxSum;
                maxSum = Math.Max(maxSum, maxSumSoFar);
                if (lastMax < maxSum)
                {
                    end = i;
                }

            }

            result = new int[] { start, end };
            return maxSum;

        }

        void FindMinimumSubString(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * -1;
            }

            int[] result = new int[2];

            int maxNegaiveSum = FindMaximumSumSubArray(nums, out result);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= result[0] && i <= result[1]) continue;

                Console.Write("{0} ", nums[i] * -1);
            }

        }

        static void Main(string[] args)
        {
            var test = new MaximumSumSubArray();
            var nums = new int[] { 2, 1, -5, 4, -3, 1, -3, 4, -1 };

            test.FindMinimumSubString(nums);

            Console.WriteLine("Hello World!");
        }
    }
         
}
