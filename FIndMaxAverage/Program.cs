using System;
using System.Collections.Generic;

namespace FIndMaxAverage
{
    public class Solution
    {
        public double FindMaxAverageOn2(int[] nums, int k)
        {

            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length < k) return 0;

            
            double sum = 0;
            double maxAverage = Int32.MinValue;

            for (int windowsStart = 0; windowsStart < nums.Length - k+1; windowsStart++)
            {
                sum = 0;
                for (int windowsEnd = windowsStart; windowsEnd < nums.Length; windowsEnd++)
                {
                    sum += nums[windowsEnd];
                    if ((windowsEnd - windowsStart)+1 >= k)
                        maxAverage = Math.Max(maxAverage, sum /((windowsEnd-windowsStart)+1));
                }
            }

            return maxAverage;
        }

        public int FindLengthOfSubArrayOfNonRepeatingChar(string str)
        {
            int windowsStart = 0;
            var charfrequencyMap = new Dictionary<char, int>();
            int maxLength = 0;

            for (int windowsEnd = 0; windowsEnd < str.Length; windowsEnd++)
            {
                if(!charfrequencyMap.ContainsKey(str[windowsEnd]))
                {

                    charfrequencyMap.Add(str[windowsEnd], 1);

                }
                else
                {
                    maxLength = Math.Max(maxLength, windowsEnd - windowsStart);
                    for (int i = windowsStart; i < windowsEnd; i++)
                    {
                        Console.WriteLine(str[i]);
                    }
                    charfrequencyMap.Remove(str[windowsStart++]);
                }
            }
            return maxLength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var sol = new Solution();
            //var result = sol.FindMaxAverageOn2(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
            //var result = sol.FindMaxAverageOn2(new int[] {3,3,4,3,0 }, 3);
            //var result = sol.FindMaxAverageOn2(new int[] {0,1,1,3,3 }, 4);
            //var result = sol.FindLengthOfSubArrayOfNonRepeatingChar("aabccbb");
            //var result = sol.FindLengthOfSubArrayOfNonRepeatingChar("abbbb");
            var result = sol.FindLengthOfSubArrayOfNonRepeatingChar("abccde");
            Console.WriteLine(result);
        }
    }
}
