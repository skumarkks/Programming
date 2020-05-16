using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadanesMaximumSumSubarray
{
    class Program
    {
        public static int[] FindMaximumSumSubArray(int[] arr, out int maxSum)
        {
            int previousSum = arr[0];
            int currentSum = arr[0];
            int maxSumSubArray = arr[0];

            int[] subArrayIdx = new int[2] { 0, 0 };

            for (int i = 1; i < arr.Length; i++)
            {
                previousSum = currentSum;
                currentSum = previousSum + arr[i];
                if(currentSum == 0)
                {
                    currentSum = arr[i];
                    subArrayIdx[0] = i;
                }

                int currentMax = maxSumSubArray;
                maxSumSubArray = Math.Max(maxSumSubArray, currentSum);

                if (currentMax < maxSumSubArray)
                    subArrayIdx[1] = i;
            }
            maxSum = maxSumSubArray;
            return subArrayIdx;

        }

        static void Main(string[] args)
        {
            int[] num = new int[] { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            int maxSum = 0;
            int[] result = Program.FindMaximumSumSubArray(num, out maxSum);

            foreach (var item in result)
            {
                Console.WriteLine(num[item]);
                
            }
            Console.WriteLine(maxSum);
            Console.WriteLine();

            num = new int[] { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };
            maxSum = 0;
            result = Program.FindMaximumSumSubArray(num,out maxSum);

            foreach (var item in result)
            {
                Console.WriteLine(num[item]);
                //Console.WriteLine(maxSum);
            }
            Console.WriteLine(maxSum);


        }
    }
}
