using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_FirstMissingPositive_41
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            //if the num is only nums
            if (nums.Length == 0)
            {
                return 1;
            }

            if (nums.Length == 1)
            {
                if (nums[0] == 0 || nums[0] < 0) return 1;
                if (nums[0] == 1) return 2;
                if (nums[0] > 1) return 1;
            }

            //scan through the nums array to find the maximum and minimum number 
            int l = int.MaxValue;
            int h = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > h)
                    h = nums[i];
                if (nums[i] < l)
                    l = nums[i];
            }

            if (h < 0)
                return 1;
            //allocate the array A base on the max value from above step
            int[] A = new int[h + 1];
            Array.Clear(A, 0, A.Length);

            //loop through the array and set A[k] to 1
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    int k = nums[i];
                    A[k] = 1;
                }
            }

            bool bFind = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (bFind == false)
                {
                    if (A[i] == 0)
                    {
                        bFind = true;
                        return i;
                    }
                }
            }

            if (bFind == false)
            {
                return h + 1;
            }

            return 1;

        }

        //public int FirstMissingPositive1(int[] nums)
        //{
        //    //if the num is only nums
        //    if (nums.Length == 0)
        //    {
        //        return 1;
        //    }

        //    if (nums.Length == 1)
        //    {
        //        if (nums[0] == 0 || nums[0] < 0) return 1;
        //        if (nums[0] == 1) return 2;
        //        if (nums[0] > 1) return 1;
        //    }

        //    //sort the arry
        //    Array.Sort(nums);
        //    // if the first number is grater than 1 reutn 1
        //    if (nums[0] > 1) return 1;
        //    // if the first number is less than 1 move to the next positive number 
        //    // if it is grater than 1 return 1
        //    //else find the differnece between the number when the difference is not 1 return the lastnumber +1
        //    bool bNegative = false;
        //    bool bfirstposive = false;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] < 1)
        //        {
        //            bNegative = true;
        //            continue;
        //        }

                
        //        bNegative = false;
        //        if (!bfirstposive)
        //        {
        //            bfirstposive = true;
        //            if (nums[i] > 1) return 1;
        //        }
        //        if ((i + 1) < nums.Length)
        //        {
        //            if (nums[i + 1] - nums[i] > 1)
        //                return nums[i] + 1;
        //        }

        //    }

        //    if (bNegative)
        //        return 1;
        //    return nums[nums.Length-1]+1;


        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            //int[] nums = new[] {1, 2, 0};
            //int[] nums = new[] { 3, 4, -1, 1 };
            //int[] nums = new[] {1,2,3,4,5,6, 7, 8, 9, 11, 12 };
            //int[] nums = new[] { 1, 2, 3, 10, 2147483647, 9};
            //int[] nums = new[] { -10, -3, -100, -1000, -239, 1};
            int[] nums = new[] { -1000, 1 };
            int i = sol.FirstMissingPositive1(nums);
            Console.WriteLine(i);

        }
    }
}
