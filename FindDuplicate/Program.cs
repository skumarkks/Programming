using System;
using System.Collections.Generic;

namespace FindDuplicate
{
    class Program
    {
        public class Duplicate
        {
            public List<int> FindDuplicate(int[] nums)
            {
                if (nums.Length == 0) return null;

                int i = 0;

                while (i < nums.Length)
                {
                    if (i < nums.Length && nums[i] != nums[nums[i] - 1])
                    {
                        Swap(nums, i, nums[i] - 1);
                    }
                    else
                    {
                        i++;
                    }
                }

                List<int> duplicate = new List<int>();
                
                for (int j = 0; j <= nums.Length-1; j++)
                {
                    if (j+1 != nums[j])
                        duplicate.Add(nums[j]);
                }
                return duplicate;
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
            var results = duplicate.FindDuplicate(new int[] { 8, 4, 3, 3, 2, 2, 1 });
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
