using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLengthOnReplaceZero
{
    class Solution
    {
        public static int FindLongestSubArray(int[] arr, int k)
        {
            if (arr.Length == 0) return -1;

            int leftIdx = 0;
            int rightIdx = 0;

            int oneCount = 0;
            int maxlength = Int32.MinValue;

            while (rightIdx < arr.Length)
            {
                int i = arr[rightIdx];

                if (i == 1)
                {
                    oneCount++;

                }

                while (rightIdx-leftIdx+1 - oneCount > k)
                {
                    maxlength = Math.Max(maxlength, rightIdx - leftIdx + 1);
                    if (arr[leftIdx] == 0) oneCount--;
                    leftIdx++;
                }

                
                rightIdx++;
            }

            return maxlength;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
            int length = Solution.FindLongestSubArray(arr, 3);
            Console.WriteLine(length);


            arr = new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 };
            length = Solution.FindLongestSubArray(arr, 2);
            Console.WriteLine(length);

        }
    }
}
