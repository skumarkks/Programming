using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Find maximum value of Sum(i* arr[i]) with only rotations on given array allowed*/
namespace GeekForGreeks_MaxSumOfArray
{
    class Program
    {
        public int FindRotationSumMax(int[] arr)
        {
            int max = Int32.MinValue;
            // rotate through the array
            for (int i = 0; i < arr.Length; i++)
            {
                // initialize the double varible
                int sum = 0;
                int count = 0;

                // run through the array with j as the pivot 
                for (int j = i; count < arr.Length; j++, count++)
                {
                    // if the j value increases beyond the arrary length
                    if (j >= arr.Length)
                    {
                        int k = j - arr.Length;
                        sum += arr[k] * count;
                    }
                    else
                    {
                        sum += arr[j] * count;
                    }
                }

                if (max < sum)
                    max = sum;
            }

            return max;
        }
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 20, 2, 10 };
            int[] arr = new int[] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var prg = new Program();
            int max = prg.FindRotationSumMax(arr);
            Console.WriteLine(max);
        }
    }
}
