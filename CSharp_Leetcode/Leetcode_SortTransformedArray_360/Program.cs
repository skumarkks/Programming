using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_SortTransformedArray_360
{
    class Program
    {
        public static  int[] SortTransformedArray(int[] nums, int a, int b, int c)
        {
            var ints = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int y = a * nums[i]* nums[i] + b * nums[i] + c;
                ints[i] = y;
            }

            Array.Sort(ints);
            return ints;
        }
        static void Main(string[] args)
        {
            var nums = new int[] {-4, -2, 2, 4};
            var output = Program.SortTransformedArray(nums, 1, 3, 5);


        }
    }
}
