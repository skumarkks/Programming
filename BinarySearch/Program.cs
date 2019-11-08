using System;

namespace BinarySearch
{
    public class BSearch
    {
        public int BinarySearch(int[] nums, int low, int high, int target)
        {
            if (low > high)
                return -1;
            
            int mid = (low + high) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {

                high = mid - 1;
                return BinarySearch(nums, low, high, target);
            }

            low = mid + 1;
            return BinarySearch(nums, low, high, target);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 6, 8, 9, 10 };
            int target = 8;

            var prg = new BSearch();
            int index = prg.BinarySearch(nums, 0, nums.Length - 1, target);

            Console.WriteLine("{0} ", index);
        }
    }
}
