using System;
using System.Collections.Generic;

namespace Quora_SubsetZero
{
    class Program
    {
        // Function to check if sub-array with 0 sum is present
        // in the given array or not
        public bool zeroSumSubarray(int[] A, int n)
        {
            // create an empty set to store sum of elements of each
            // sub-array A[0..i] where 0 <= i < n
            HashSet<int> set = new HashSet<int>();

            // insert 0 into set to handle the case when sub-array with
            // 0 sum starts from index 0
            set.Add(0);

            int sum = 0;

            // traverse the given array
            for (int i = 0; i < n; i++)
            {
                // sum of elements so far
                sum += A[i];

                // if sum is seen before, we have found a sub-array with 0 sum
                if (set.Contains(sum))
                {
                    return true;
                }
                else
                {
                    // insert sum so far into set
                    set.Add(sum);
                }
            }

            // we reach here when no sub-array with 0 sum exists
            return false;
        }


        static void Main(string[] args)
        {
            var prg = new Program();
            bool result = prg.zeroSumSubarray(new int[] { 4, 2, -3, -1, 0, 4 }, 6);

            Console.WriteLine(result);
        }
    }
}
