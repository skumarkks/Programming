using System;

namespace MoveZero
{
    class Program
    {
        public void MoveAllZeroToRight(int[] nums)
        {
            if (nums.Length == 0 && nums.Length == 1) return;

            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k++] = nums[i];
                }
            }
            for (int i = k; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 3, 0, 5, 0, 8 };
            int[] expected = new int[] { 1, 3, 5, 8, 0, 0, 0 };

            var prg = new Program();
            prg.MoveAllZeroToRight(nums);

            bool bResult = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == expected[i])
                {
                    bResult = true;
                }
                else
                {
                    bResult = false;
                    break;
                }
            }
            if(bResult == true)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }
    }
}
