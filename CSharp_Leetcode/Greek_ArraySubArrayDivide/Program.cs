using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greek_ArraySubArrayDivide
{
    class Program
    {
        // Uitlity function to print the sub-array 
        public static  void printSubArray(int[] arr, int start, int end)
        {
            Console.WriteLine("[ ");
            
            for (int i = start; i <= end; i++)
                Console.WriteLine(arr[i] + " ");

            Console.WriteLine(" ]");
        }

        // Function that divides the array into two subarrays 
        // with the same sum 
        public static bool divideArray(int[] arr, int n)
        {
            // sum stores sum of all elements of the array 
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // sum stores sum till previous index of the array 
            int sum_so_far = 0;

            for (int i = 0; i < n; i++)
            {
                // If on removing arr[i], we get equals left 
                // and right half 
                if (2 * sum_so_far + arr[i] == sum)
                {
                    Console.WriteLine("The array can be divided into two subarrays with equal sum\nThetwo subarrays are - ");
                    
                    printSubArray(arr, 0, i - 1);
                    printSubArray(arr, i + 1, n - 1);

                    return true;
                }
                // add current element to sum_so_far 
                sum_so_far += arr[i];
            }

            // The array cannot be divided 
            Console.WriteLine("The array cannot be divided into two subarrays with equal sum");
            

            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 2, 3, 2, 1 };
            Program.divideArray(arr, arr.Length);
            
        }
    }
}
