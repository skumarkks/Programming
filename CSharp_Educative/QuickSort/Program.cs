using System;

namespace QuickSort
{
    /*class Program
    {
        public int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            int l = low;
            int h = high;

            do
            {
                do
                {
                    l++;
                    if (l >= nums.Length)
                    {
                        l--;
                        break;
                    }
                } while (nums[l] <= pivot);
                do
                {
                    h--;
                    if (h < 0)
                    {
                        h++;
                        break;
                    }
                } while (nums[h] > pivot);

                if (l < h)
                    swap(nums, low, h);
            } while (l < h);
            swap(nums, low, h);

            return h;
        }

        private void swap(int[] nums, int l, int h)
        {
            int temp = nums[l];
            nums[l] = nums[h];
            nums[h] = temp;
        }

        public void QuickSort(int[] nums, int low, int high)
        {
            if(low < high)
            {
                int index = Partition(nums, low, high);
                QuickSort(nums, low, index);
                QuickSort(nums, index + 1, high);
            }
        }

        static void Main(string[] args)
        {
            var prg = new Program();
            //var nums = new int[] { 11, 13, 7, 12 };
            var nums = new int[] { 1, -1 };
            prg.QuickSort(nums, 0, nums.Length);
            foreach (var item in nums)
            {
                Console.Write("{0} ", item);
            }
            
            Console.WriteLine("Hello World!");
        }
    }*/
}
