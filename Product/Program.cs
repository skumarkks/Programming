using System;

namespace Product
{
    class Program
    {
        public void Product(int[] nums)
        {
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];

            left[0] = right[nums.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = nums[i-1] * left[i-1];
            }

            for(int j = nums.Length-2;j >=0; j--)
            {
                right[j] = nums[j + 1] * right[j + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = left[i] * right[i];
            }

        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            var prg = new Program();
            prg.Product(nums);
            Console.WriteLine("Hello World!");
        }
    }
}
