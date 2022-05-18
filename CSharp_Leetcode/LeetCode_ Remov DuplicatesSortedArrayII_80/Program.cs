using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode__Remov_DuplicatesSortedArrayII_80
{
    class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3)
                return nums.Length;

            bool bSame = false;
            int count = 0;
            int i = 0;

            for (i = 0; i < nums.Length-2; i++)
            {
                // not same and bsame = false
                if(((nums[i] != nums[i+1] && nums[i] != nums[i + 2]) || 
                    (nums[i] == nums[i + 1] && nums[i] != nums[i + 2])) && bSame == false)
                {
                    count++; 
                }
                //same and bsame = false
                else if ((nums[i] == nums[i + 1]) && (nums[i] == nums[i + 2]) && bSame == false)
                {
                    count++;
                    bSame = true;
                }
                // same and bsame = true
                else if ((nums[i] == nums[i + 1]) && (nums[i] == nums[i + 2]) && bSame)
                {
                    if (nums[count] != nums[i])
                    {
                        count++;
                        nums[count] = nums[i];
                        count++;
                        nums[count] = nums[i+1];
                        //bSame = false;
                    }
                }
                //not same and bsame = true
                else if (((nums[i] != nums[i + 1]) && (nums[i] != nums[i + 2])) ||
                         ((nums[i] == nums[i + 1]) && (nums[i] != nums[i + 2])) && bSame)
                {
                    if (nums[count] != nums[i])
                    {
                        count++;
                        nums[count] = nums[i];
                        count++;
                        nums[count] = nums[i + 1];
                        // bSame = false;
                    }
                }
            }
            if (nums[count] != nums[i])
            {
                count++;
                nums[count] = nums[i];
                // bSame = false;
            }

            if (nums[count] != nums[i + 1])
            {
                count++;
                nums[count] = nums[i + 1];
            }

            if (nums[count] == nums[i + 1] && nums[count-1] != nums[i + 1])
            {
                count++;
                nums[count] = nums[i + 1];
            }


            return count + 1;
        }

        public int RemoveDuplicates1(int[] nums)
        {
            int count = 1;
            bool hasAppeared = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    nums[count++] = nums[i];
                    hasAppeared = false;
                }
                else if (nums[i - 1] == nums[i] && !hasAppeared)
                {
                    nums[count++] = nums[i];
                    hasAppeared = true;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {0,0,1,1,1,1,2,2,2,3,3,4,5};

            //int[] nums = new int[] {0, 0, 1, 1, 1, 1, 2, 3, 3};
            var prg = new Program();
            //prg.RemoveDuplicates(nums);
            int c = prg.RemoveDuplicates1(nums);
        }
    }
}
