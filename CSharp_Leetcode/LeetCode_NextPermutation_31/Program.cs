using System;

namespace LeetCode_NextPermutation_31
{
    public class Solution
    {
        private static int min = Int32.MaxValue;
        private static int baseVal;
        private int[] nextMinPermutation;

        public void NextPermutation(int[] nums)
        {
            // if the nums contains only one element
            if (nums.Length == 1)
                return;

            //check is the number is decending order then next permutation is the reverse number
            bool isReverse = false;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    isReverse = true;
                }
                else
                {
                    isReverse = false;
                    break;
                }
            }

            if (isReverse)
            {
                Reverse(nums);
                return;
            }

            int l = 0;
            int h = nums.Length - 1;
            baseVal = GetValue(nums);
            nextMinPermutation = new int[nums.Length];

            Permutation(nums, l, h);
            //nums = nextMinPermutation;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nextMinPermutation[i];
            }

        }

        private void Reverse(int[] nums)
        {
            for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
            {
                Swap(nums,i,j);
            }
        }

        private void Permutation(int[] nums, int l, int h)
        {
            if (l == h)
            {
                int currentVal = GetValue(nums);
                if (currentVal != baseVal)
                {
                    if (min > (currentVal - baseVal))
                    {
                        min = currentVal - baseVal;
                        for (int i = 0; i < nums.Length; i++)
                        {
                            nextMinPermutation[i] = nums[i];
                        }
                    }
                }
            }


            for (int i = l; l < h  && i < nums.Length; i++)
            {
                Swap(nums, l, i);
                Permutation(nums, l + 1, h);
                Swap(nums, l, i);
            }
        }

        private int GetValue(int[] nums)
        {
            int val = 0;

            for (int i = nums.Length - 1, j=0; i >= 0; i--, j++)
            {
                val +=  nums[i] * (int)Math.Pow(10, j);
            }

            return val;
        }

        private void Display(int[] nums)
        {
            foreach (var i in nums)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        private void Swap(int[] nums, int l, int i)
        {
            int temp = nums[l];
            nums[l] = nums[i];
            nums[i] = temp;
        }


        static void Main(string[] args)
        {
            var prg = new Solution();
            //int[] nums = new[] {1, 2, 3};
            //int[] nums = new[] { 3, 2, 1 };
            //int[] nums = new[] { 1, 1, 5 };

            int[] nums = new[] { 1, 2 };

            prg.NextPermutation(nums);
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}



