using System;

namespace MergeSortRecursive
{
    class Program
    {
        public static int[] MergeSort(int[] nums, int low, int high)
        {
            int[] temp = new int[nums.Length];

            if(low < high)
            {
                MergeSort(nums, temp, 0, nums.Length-1);
            }
            return temp;
        }

        public static void MergeSort(int[] nums, int[] temp, int low, int high)
        {           
            int mid = (low + high) / 2;

            if (low < high)
            {
                MergeSort(nums, temp, low, mid);
                MergeSort(nums, temp, mid + 1, high);
                Merge(nums, temp, low, mid, high);
            }
        }

        public static void Merge(int[] nums, int[] temp, int low, int mid, int high)
        {
            
            int left = low;
            int right = mid + 1;
            int k = low;

            while(left <= mid && right <= high)
            {
                if (nums[left] <= nums[ right])
                {
                    temp[k++] = nums[left++];
                }
                else
                {
                    temp[k++] = nums[right++];
                }
            }

            
            for (int i = left; i <= mid; i++)
            {
                temp[k++] = nums[i]; 
            }

            for (int i = right; i <= high; i++)
            {
                temp[k++] = nums[i];
            }

            for(int i = low; i<= high;i++)
            {
                nums[i] = temp[i];
            }

            //nums = temp;
            foreach (var item in temp)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            var nums = new int[] { 8, 2, 9, 6, 5, 3, 7, 4 };
            var temp = MergeSort(nums, 0, 7);

            foreach (var item in temp)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
