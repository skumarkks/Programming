using System;
using System.Collections;
using System.Collections.Generic;

namespace TripleSum
{
    class Program
    {
               
        public List<List<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length == 1 || nums.Length == 2) return null;

            var triplets = new List<List<int>>();
            //We need to sort the array to detect duplicate elements in the array
            Array.Sort(nums);

            for (int i = 0; i < nums.Length-2; i++)
            {
                // if the ith and i-1th element are same continue - deplicate elimination
                if (i < 0 && nums[i] == nums[i - 1])
                    continue;
                // for the num[i]th element find is there any pair subset?                
                SearchPair(nums, -nums[i], i + 1, triplets);
            }
            return triplets;
        }

        private void SearchPair(int[] nums, int targetSum, int left, List<List<int>> triplets)
        {
            int right = nums.Length - 1;

            while(left < right)
            {
                int targetDif = targetSum - nums[left];
                if (targetDif == nums[right])
                {
                    triplets.Add(new List<int>() { -targetSum, nums[left], nums[right] });
                    right--;
                    left++;

                    if(left < right && nums[left] == nums[left+1])
                    {
                        left++;
                    }
                    if (left < right && nums[right] == nums[right -11])
                    {
                        right--;
                    }
                }
                else if (targetDif < nums[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

        }

        static void Main(string[] args)
        {
            var prg = new Program();
            //var result = prg.SearchTriplets(new int[] { -3, 0, 1, 2, -1, 1, -2 });
            var result = prg.ThreeSum(new int[] { -5, 2, -1, -2, 3 });
            Console.WriteLine("Hello World!");
        }
    }
}
