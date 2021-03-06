using System;

namespace MaxSumSubArray
{
    class Program
    {
        
        public int FindMinSubArray(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;

            int min = Int32.MaxValue;

            int sum = 0;
            int first = nums[0];

            for (int i = 0; i < k; i++)
            {
                sum = sum + nums[i];
            }

            min = Math.Min(min, sum);

            for (int i = 1; i < nums.Length - k + 1; i++)
            {
                sum = sum - first + nums[i + k - 1];
                min = Math.Min(min, sum);
                first = nums[i];
            }

            return min;
        }


        public int FindMaxSumArray(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;
            
            int max = Int32.MinValue;

            int sum = 0;
            int first = nums[0];            

            for (int i = 0; i < k; i++)
            {
                sum = sum + nums[i];
            }

            max= Math.Max(max, sum);

            for (int i = 1; i < nums.Length-k+1; i++)
            {
                sum = sum - first + nums[i+k-1];
                max = Math.Max(max, sum);
                first = nums[i];                
            }

            return max;
        }

        /*static void Main(string[] args)
        {
            var prg = new Program();

            //int[] nums = {2,1,5,1,3,2};
            //int[] nums = {2,3,4,1,5 };
            //
            //int result = prg.FindMaxSumArray(nums, 2);

            //Console.WriteLine(result);

            int[] nums1 = { 2, 1, 5, 2, 3, 2};
            int result = prg.FindMinSubArray(nums1, 7);

            Console.WriteLine(result);
        }*/
    }
    public class SubArray
    {
        public int FindMaxSumSubArray(int[] num, int k)
        {
            if (num.Length == 0 || num.Length < k) return -1;

            int start = 0;
            int end = 0;
            int sum = 0;
            int maxSum = Int32.MinValue;

            while( end < num.Length)
            {
                sum += num[end];

                if (end - start + 1 == k)
                {
                    maxSum = Math.Max(maxSum, sum);
                    sum -= num[start];
                    start++;
                }
                end++;
            }
            return maxSum;
        }

        static void Main(string[] args)
        {
            var test = new SubArray();
            var num = new int[] { 2, 1, 5, 1 };
            int expected = 8;
            int result = test.FindMaxSumSubArray(num, 3);
            if (result == expected)
            {
                Console.WriteLine("Passed: result {0}, expected {1}", result, expected );
            }


            num = new int[] { 2, -1, 5, 1 };
            expected = 6;
            result = test.FindMaxSumSubArray(num, 3);
            if (result == expected)
            {
                Console.WriteLine("Passed: result {0}, expected {1}", result, expected );
            }

            num = new int[] { 2, -1 };
            expected = -1;
            result = test.FindMaxSumSubArray(num, 3);
            if (result == expected)
            {
                Console.WriteLine("Passed: result {0}, expected {1}", result, expected );
            }

            num = new int[] { };
            expected = -1;
            result = test.FindMaxSumSubArray(num, 3);
            if (result == expected)
            {
                Console.WriteLine("Passed: result {0}, expected {1}", result, expected );
            }

        }
    }

}
