using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_RotateArray
{
    class Program
    {
        /*public void Rotate(int[] nums, int k)
        {
            
            // divide the array into two
            int startIndex = 0;
            int lenArray = nums.Length;

            if (lenArray == 1)
                return;

            int arrayDividor = lenArray - k;
            if (arrayDividor < 0)
            {
                arrayDividor = k-1;
            }

            try
            {

                // reverse the first half of the array
                ReverseArray(nums, startIndex, arrayDividor - 1);

                if (k < lenArray)
                {
                    //reverse the second half of the array
                    ReverseArray(nums, arrayDividor, lenArray - 1);
                    // reverse the entire array
                    ReverseArray(nums, 0, lenArray - 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }*/

        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            ReverseArray(nums, 0, nums.Length - 1);
            ReverseArray(nums, 0, k - 1);
            ReverseArray(nums, k, nums.Length - 1);
        }

        private void ReverseArray(int[] ints, int startIndex, int arrayDividor)
        {
            try
            {
                for (int i = startIndex, j = arrayDividor; i < j; i++, j--)
                {
                    int first = ints[i];
                    ints[i] = ints[j];
                    ints[j] = first;
                }
            }
            catch (Exception e)
            {
                
               throw;
            }
           
        
        }

        static void Main(string[] args)
        {
            int[] a = {1,5,3};
            int k = 4;

            Program p = new Program();
            p.Rotate(a,11);

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }


        }
    }
}
