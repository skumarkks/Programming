using System;
using System.Collections.Generic;

namespace PermutationNumbers
{
    public class NumberPermutation
    {
        //Time O(n!) and O(n!*n)
        void Permutation(int[] nums, int l, int h, List<IList<int>> perms)
        {
            if (l == h)
            {
                List<int> lnums = new List<int>(nums);
                perms.Add(lnums);
            }
            else
            {
                for (int i = l; i <= h; i++)
                {
                    swap(nums, l, i);
                    Permutation(nums, l + 1, h, perms);
                    swap(nums, l, i);
                }
            }
        }

        void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] arg)
        {
            var test = new NumberPermutation();
            int[] nums = new int[] { 1, 2, 3,4 };
            var perms = new List<IList<int>>();
            test.Permutation(nums, 0, nums.Length - 1, perms);
        

            foreach (var item in perms)
            {
                foreach (var i in item)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();
            }

        }
    }

}
