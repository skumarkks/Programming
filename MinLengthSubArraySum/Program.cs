using System;
using System.Collections.Generic;

namespace MinLengthSubArraySum
{
    public class SubArrays
    {
        //Time Complexity O(n)
        //Space Complexity O(
        public List<int> SmallestSubArraySum(int[] nums, int k)
        {
            int start = 0;
            int end = 0;

            int sum = 0;
            int minSize = Int32.MaxValue;

            int startIndex = -1;
            int endIndex = -1;

            if (nums.Length == 0) return null;

            for (end = 0; end < nums.Length; end++)
            {
                sum += nums[end];

                while(sum >= k)
                {
                    if(sum == k)
                    {
                        int oldMinSize = minSize;
                        minSize = Math.Min(minSize, end - start + 1);
                        if(oldMinSize != minSize)
                        {
                            startIndex = start;
                            endIndex = end;
                        }

                        sum -= nums[start];
                        start++;

                    }
                    else if(sum > k)
                    {
                        sum -= nums[start];
                        start++;
                    }                                          
                }

            }
            var result = new List<int>();
            if (startIndex != -1 && endIndex != -1)
            {               

                for (int i = startIndex; i <= endIndex; i++)
                {
                    result.Add(nums[i]);
                }
            }

            return result;

        }

        public static void Main(string[] args)
        {
            var test = new SubArrays();
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 7 };
    
            var result = test.SmallestSubArraySum(nums, 20);

            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();


        }
    }

}
