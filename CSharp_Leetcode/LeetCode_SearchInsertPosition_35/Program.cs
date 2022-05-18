using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_SearchInsertPosition_35
{
    class Program
    {
        public int SearchInsert(int[] nums, int target)
        {
            // if the target is less than nums[0]
            if (target < nums[0])
            {
                return 0;
            }
            // if the target is greater than nums[nums.length-1]
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }

            if (target == nums[0])
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                
                // if the target is equal to the given number
                if (nums[i] == target)
                {
                    return i;
                }
                // if the target is in between the two numbers
                else if ((i < nums.Length - 1) && (nums[i] < target && nums[i+1] > target))
                {
                    return i + 1;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = new[] {1,3};
            var prg = new Program();
            prg.SearchInsert(nums, 3);
        }
    }
}
