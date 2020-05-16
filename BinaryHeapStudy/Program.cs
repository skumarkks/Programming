using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapStudy
{
    
    class Program
    {
        public void BinaryMaxHeapInsert(int[] nums, int index)
        {
            int temp = nums[index];
            int i = index;

            while(i > 0 && temp > nums[i/2])
            {
                nums[i] = nums[i / 2];
                i = i / 2;
            }

            nums[i] = temp;
        }

        public void BinaryHeapDelete(int[] nums, int index)
        {
            int temp = nums[index];
            nums[0] = nums[nums.Length-1];

            int i = 0;
            int j = 2*i + 1;

            while(i < nums.Length-2 && j < nums.Length-1)
            {
                if(nums[j+1] > nums[j])
                {
                    j = j + 1;
                }

                if(nums[i] < nums[j])
                {
                    swap(nums, i, j);
                    i = j;
                    j = 2 * i + 1;
                }
            }
            nums[index] = temp;

        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 40, 35, 30, 15, 10, 25, 5 };

            var test = new Program();
            //test.BinaryMaxHeapInsert(nums, 6);
            test.BinaryHeapDelete(nums, 0);
                
        }
    }
}
