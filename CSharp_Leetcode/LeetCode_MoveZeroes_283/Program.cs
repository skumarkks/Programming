using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_MoveZeroes_283
{
    class Program
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1)
                return;

            int count = 0;
            int i = 0;
            

            while (i < nums.Length-1)
            {
                if (nums[i] != 0)
                {
                    count++;
                    i++;
                }
                else if(nums[i] == 0 && nums[i+1] != 0)
                {
                    int temp = nums[count];
                    nums[count++] = nums[i + 1];
                    nums[i + 1] = temp;
                    i++;
                }
                else
                {
                    i++;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            //int[] nums = new int[] { 1, 0, 1 };

            var prg = new Program();
            prg.MoveZeroes(nums);
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
