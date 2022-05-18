using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CheckPossibility_665
{
    class Program
    {
        public bool CheckPossibility(int[] nums)
        {
            int count = 0;
            bool incrementing = false;
            bool flag = false;

            if (nums.Length == 0)
                return false;
            if (nums.Length == 1)
                return true;


            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    incrementing = true;
                }
                else
                {
                    if (count == 1)
                    {
                        return false;
                    }

                    flag = true;
                    if (nums[i] > nums[i + 1])
                    {
                        nums[i] = nums[i + 1];
                    }
                    else
                    {
                        nums[i + 1] = nums[i];
                    }
                    count = count + 1;
                }
            }

            if (incrementing && flag && count == 1)
                return true;

            if (incrementing && flag == false && count == 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            //int[] nums = new[] {4, 2, 3};
            int[] nums = new[] { 3, 4, 2,3};


            var p = new Program();
            bool t = p.CheckPossibility(nums);
            Console.WriteLine(t);
        }
    }
}
