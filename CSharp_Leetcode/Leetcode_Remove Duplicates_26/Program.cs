using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Remove_Duplicates_26
{
    class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            //compare the num[i] and num[i+1] if same move i 
            //compare the num[i] and num[i+1] if different and is different from num[count]
            //increament count and num[count] = num[i+1] and increment i

            int count = 0;
            int i = 0;
            while(i < nums.Length-1)
            {
                if (i + 1 <= nums.Length - 1)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        i++;
                    }
                    else if ((nums[i] != nums[i + 1]) && (nums[i + 1] != nums[count]))
                    {
                        count++;
                        nums[count] = nums[i + 1];
                        i++;
                    }
                }
            }
            return count+1;
        }
        static void Main(string[] args)
        {
            //int[] nums = new int[] {1, 1, 2};
            //int[] nums = new int[] {1, 1, 2,2,3,3,4,5};
            //int[] nums = new int[] { 1, 1 };
            //int[] nums = new int[] { 1, 2 };
            //int[] nums = new int[] { 1, 2,3 };
            //int[] nums = new int[] { 1, 2, 3,3 };
            int[] nums = new int[] { 1, 1, 1, 1, 3, 4, 4,4, 5 };

            var prg = new Program();
            int count = prg.RemoveDuplicates(nums);
            Console.WriteLine(count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
