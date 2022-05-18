using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_BubbleSort
{
    class Program
    {
        public int[] BubbleSort(int[] nums, int pass)
        {
            if (nums != null)
            {
                //int pass = nums.Length - 1;

                //loop for the pass
                for (int p = 0; p < pass; p++)
                {
                    //loop for the swap
                    for(int i =0; i < (nums.Length-1) - p; i++)
                    {
                        // for positive integers
                        if(nums[i] > nums[i+1])
                        {
                            Swap(nums, i, i + 1);
                        }
                    }
                }

            }

            return nums;
        }

        void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }


        static void Main(string[] args)
        {
            //int[] nums = new int[] { 8, 5, 7, 3, 2 };
            //int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int[] nums = new int[] { 8, 8, 7, 3, 2 };
            var prg = new Program();
            int[] result = prg.BubbleSort(nums, 4);
            foreach( var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
