using System;

namespace MaximumSumSubArray
{
    public class Substring
    {
        int[] FindLongestSumSubstring(int[] nums, out int result)
        {
            result = 0;
            if (nums.Length == 0) return new int[] { };
            result = nums[0];
            if (nums.Length == 1) return nums;

            int sumSofar = nums[0];
            int maxSum = 0;

            int start = 0;
            int end = 0;
            

            for (int i = 1; i < nums.Length; i++)
            {
                int lastSum = sumSofar;
                sumSofar = Math.Max(sumSofar + nums[i], nums[i]);                
        
                if (sumSofar == nums[i])
                    start = i;

                int lastMaxSum = maxSum;
                maxSum = Math.Max(maxSum, sumSofar);

                if (lastMaxSum < maxSum)
                    end = i;

            }

            result = maxSum;
            return new int[] { start, end };
        }

        public static void Main(string[] args)
        {
            var test = new Substring();
            int[] nums = new int[] { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1 };
            int maxSum;
            var result = test.FindLongestSumSubstring(nums, out maxSum);

            for (int i = result[0]; i <= result[1]; i++)
            {
                Console.Write("{0} ",nums[i]);
            }

            Console.WriteLine("MaxSum: {0}", maxSum);

            nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            result = test.FindLongestSumSubstring(nums, out maxSum);

            for (int i = result[0]; i <= result[1]; i++)
            {
                Console.Write("{0} ", nums[i]);
            }

            Console.WriteLine("MaxSum: {0}", maxSum);
        }
    }

}
