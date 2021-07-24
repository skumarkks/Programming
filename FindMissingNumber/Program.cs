using System;

namespace FindMissingNumber
{
    class Program
    {
        public static int FindMissingNumber(int[] nums)
        {
            int i = 0;
            while(i < nums.Length)
            {
                if(nums[i] < nums.Length &&
                   i != nums[i])
                {
                    Swap(nums, i, nums[i]);
                }
                else
                {
                    i++;
                }
            }

            for ( i = 0; i < nums.Length; i++)
            {
                if (i != nums[i]) return i;

            }

            return 0;

        }

        private static void Swap(int[] nums, int i, int v)
        {
            int temp = nums[i];
            nums[i] = nums[v];
            nums[v] = temp;
        }

        static void Main(string[] args)
        {
            var result = Program.FindMissingNumber(new int[] { 4, 3, 0, 1 });
            Console.WriteLine(result);

            result = Program.FindMissingNumber(new int[] { 8,3,5,2,4,6,0,1 });
            Console.WriteLine(result);
        }
    }
}
