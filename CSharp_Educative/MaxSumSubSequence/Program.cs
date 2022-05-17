using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace MaxSumSubSequence
{

    public class SubSequency
    {
        //Time O(n2) and Space O(n)
        public static List<List<int>> FindMaxSumSubSequence(int[] arr)
        {
            
            if (arr.Length == 0) return null;

            int maxSumIdx = -1;
            int maxSum = Int32.MinValue;

            int[] sum = (int[])arr.Clone();
            var sequence = new int[arr.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[0] = Int32.MinValue;
            }

            for (int currentIdx = 0; currentIdx < arr.Length; currentIdx++)
            {
                for (int otherIdx = 0; otherIdx <= currentIdx; otherIdx++)
                {
                    if (arr[currentIdx] > arr[otherIdx])
                    {
                        int currentSum = sum[otherIdx] + arr[currentIdx];
                        if (currentSum > sum[currentIdx])
                        {
                            sum[currentIdx] = currentSum;
                            sequence[currentIdx] = otherIdx;
                            int currentMax = maxSum;
                            maxSum = Math.Max(maxSum, currentSum);
                            if (currentMax != maxSum)
                                maxSumIdx = currentIdx;
                        }
                    }
                }
            }
            var result = BuildSequence(arr, sequence, maxSum, maxSumIdx);

            return result;
        }

        public static List<List<int>> BuildSequence(int[] arr, int[] sequence, int maxSum, int maxSumIdx)
        {
            var result = new List<List<int>>();
            result.Add(new List<int>());
            result.Add(new List<int>());
            result[0].Add(maxSum);

            int i = maxSumIdx;
            
            while (i >= 0)
            {
                result[1].Add(arr[i]);
                i = sequence[i];
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new int[] { 8, 12, 2, 3, 15, 5, 7 };

            var result = SubSequency.FindMaxSumSubSequence(test1);
        }
    }
}
