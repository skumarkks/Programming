using System;
using System.Collections.Generic;

namespace MaximumLengthSubArrayOfSum
{
    class Program
    {
        public void FindMaximumLengthSubArrayOfSumHash(int[] nums, int target)
        {
            var freqSum = new Dictionary<int, int>();
            int sum = 0;
            freqSum.Add(0, -1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(freqSum.ContainsKey(sum-target))
                {
                    int k = freqSum[sum-target];
                    for (int j = k+1; j < i; j++)
                    {
                        Console.Write("{0} ", nums[j]);
                    }
                }
                else
                {
                    if (!freqSum.ContainsKey(sum))
                        freqSum.Add(sum, i);
                }
            }

        }
        public void MaximumLengthSubArrayOfSum(int[] nums, int target)
        {
            if (nums.Length == 0) return;

            int windowsStart = 0;
            int sum = 0;
            int maxSubArray = 0;
            var listAll = new List<List<int>>();

            for (int windowsEnd = 0; windowsEnd < nums.Length; windowsEnd++)
            {
                sum += nums[windowsEnd];
                if(sum == target)
                {
                    var list = new List<int>();
                    for (int i = windowsStart; i <= windowsEnd; i++)
                    {
                        list.Add(nums[i]);
                    }
                    listAll.Add(list);
                    maxSubArray = Math.Max(maxSubArray, windowsEnd - windowsStart+1);
                }
                else if (sum > target)
                {
                    sum -= nums[windowsStart];
                    windowsStart++;
                }
            }

            foreach (var item in listAll)
            {
                if(item.Count == maxSubArray)
                {
                    foreach (var i in item)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var prg = new Program();
            prg.MaximumLengthSubArrayOfSum(new[] { 5, 6, -5, 5, 3, 5, 3, -2, 0 },8);
            Console.WriteLine("Hello World!");
            prg.FindMaximumLengthSubArrayOfSumHash(new[] { 5, 6, -5, 5, 3, 5, 3, -2, 0 }, 8);
            Console.WriteLine("Hello World!");
        }
    }
}
