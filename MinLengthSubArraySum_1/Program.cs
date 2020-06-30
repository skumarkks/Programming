using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinLengthSubArraySum_1
{
    class Solution
    {
        public static int FindSmallestSubarrayBySum(int[] array, int sum)
        {
            if (array.Length == 0) return 0;

            int windowStart = 0;
            int currentSum = 0;
            int minLength = Int32.MaxValue;


            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                currentSum += array[windowEnd];

                while (windowStart < array.Length && currentSum >= sum)
                {
                    minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                    currentSum -= array[windowStart];
                    windowStart++;
                }
            }

            return minLength;
        }


        static void Main(string[] args)
        {
            int[] test1 = new int[] { 2, 1, 5, 2, 3, 2 };
            int sum = 7;

            int actual = Solution.FindSmallestSubarrayBySum(test1, sum);
            int expected = 2;

            Console.WriteLine(actual == expected ? "Pass" : "Fail");

            int[] test2 = new int[] { 2, 1, 5, 2, 8 };
            sum = 7;

            actual = Solution.FindSmallestSubarrayBySum(test1, sum);
            expected = 1;

            Console.WriteLine(actual);
            Console.WriteLine(actual == expected ? "Pass" : "Fail");

        }
    }
}
