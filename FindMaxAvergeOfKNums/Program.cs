using System;

namespace FindMaxAvergeOfKNums
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {

            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length < k) return 0;

            int windowsStart = 0;
            int windowsEnd = 0;

            double sum = 0.0;
            double maxAverage = Int32.MinValue;

            while (windowsEnd < nums.Length)
            {
                if (windowsEnd < k)
                {
                    sum += nums[windowsEnd++];
                }
                else
                {
                    sum = sum - nums[windowsStart++] + nums[windowsEnd++];
                }

                if (windowsEnd > k)
                    maxAverage = Math.Max(maxAverage, sum);
            }

            return maxAverage / k;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            double result = sol.FindMaxAverage(new int[] { 8535, -7482, -9148, 4029, 4086, -2863, -761, -1968, -9685, -6176, -1254, 2445, 1039, 2321, 917, -2641, -8077, 6421, 7040, 5340, 4639, 5261, -7277, 4932, 4253, -5315, 1561, -5930, -6204, -3061, 401, 7519, -9094, 7907, 847, 5083, 6096, -9552, 6772, 7985, -444, -2886, 6317, 4966, -6980 }, 45);

            Console.WriteLine("Hello World!");
        }
    }
}


