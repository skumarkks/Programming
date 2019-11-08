using System;

namespace FindDuplicate
{
    class Program
    {
        public class Duplicate
        {
            public int FindDuplicate(int[] nums)
            {
                if (nums.Length == 0) return -1;

                int i = 0;

                while (i < nums.Length)
                {
                    if (i != nums[i] && nums[i] < nums.Length)
                    {
                        if (nums[i] == nums[nums[i]])
                            return nums[i];
                        else
                        {
                            Swap(nums, i, nums[i]);
                        }

                    }
                    else
                    {
                        i++;
                    }
                }
                return -1;
            }

            public void Swap(int[] nums,int i,int j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

        static void Main(string[] args)
        {
            var duplicate = new Duplicate();
            int result = duplicate.FindDuplicate(new int[] { 4, 3, 3, 0, 1 });
            Console.WriteLine(result);
            if (result == 4)
                Console.Write("Passed");
            else
                Console.Write("Failed");

            Console.WriteLine("Hello World!");
        }
    }
}
