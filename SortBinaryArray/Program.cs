using System;

namespace SortBinaryArray
{
    class Program
    {
        public int[] SortBinaryArray(int[] nums)
        {
            if (nums.Length == 0) return null;

            int i = 0;
            int j = nums.Length - 1;

            while(i < j)
            {
                if(nums[i]< nums[j])
                {
                    i++;
                    j--;
                }
                else if(nums[i] > nums[j])
                {
                    swap(nums, i, j);
                    i++;
                    j--;
                }
                else if(nums[i] == 0 && nums[j] == 0)
                {
                    i++;
                }
                else if (nums[i] == 1 && nums[j] == 1)
                {
                    j--;
                }

            }
            return nums;
        }

        public int[] SortBinary(int[] nums)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    nums[i] = 0;
                    k++;
                    i++;
                }
            }
            k++;
            while(k < nums.Length)
            {
                nums[k] = 1;
                k++;
            }
            return nums;
        }

        public int[] SortBinaryByPivot(int[] nums)
        {
            
            int j = 0;

            int pivot = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] < pivot)
                {
                    swap(nums, i, j);
                    j++;
                }

            }
            return nums;
        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            var result = prg.SortBinaryArray(new int[] { 1, 0, 0, 1, 0, 1, 0 });
            foreach (var i in result)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            result = prg.SortBinary(new int[] { 1, 0, 0, 1, 0, 1, 0 });
            foreach (var i in result)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            result = prg.SortBinaryByPivot(new int[] { 1, 0, 0, 1, 0, 1, 0 });
            foreach (var i in result)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
