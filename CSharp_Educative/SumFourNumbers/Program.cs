using System;
using System.Collections.Generic;

namespace SumFourNumbers
{
    class Program
    {
        public void FourNumberSum(int[] nums, int target, List<IList<int>> result)
        {
            if (nums.Length < 4) result = null;

            Array.Sort(nums);
            //result = new List<IList<int>>();

            for (int i = 0; i < nums.Length-3; i++)
            {
                int left = i + 2;
                int right = nums.Length - 1;

                for (int j = i + 1; j < nums.Length - 2;j++)
                {
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;
                        }
                        else if (target < sum)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }

                    left = j + 2;
                    right = nums.Length - 1;

                }


            }            
        }

        static void Main(string[] args)
        {

            var prg = new Program();
            int[] nums = new int[] { 7,6,4,-1,1,2};
            var result = new List<IList<int>>();
            prg.FourNumberSum(nums, 16, result);

            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
