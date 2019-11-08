using System;

namespace Equilibrium
{
    class Program
    {
        public void FindEquilibrium(int[] nums)
        {
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                leftSum += nums[i];
            }

            int rightSum = 0;
            int currentLeftSum = leftSum;

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                rightSum += nums[i];
                if (currentLeftSum == rightSum)
                {
                    Console.Write("{0} ",i);
                }

                currentLeftSum = currentLeftSum - nums[i];
            }
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            int[] nums = new int[] { 0, -3, 5, -4, -2, 3, 1, 0 };
            prg.FindEquilibrium(nums);
            Console.WriteLine("Hello World!");
        }
    }
}
