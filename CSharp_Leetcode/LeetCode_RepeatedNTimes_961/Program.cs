using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_RepeatedNTimes_961
{
    class Program
    {
        public  static int RepeatedNTimes(int[] A)
        {
           
            int repeatTimes = A.Length / 2;
            int repeatElement = -10000;

            Array.Sort(A);

            int curreentCount = 1;
            int previous = A[0];
            int current = A[1];

            for (int i = 1; i < A.Length; i++)
            {
                previous = A[i - 1];
                current = A[i];

                if (previous == current)
                {
                    curreentCount++;
                    if (curreentCount == repeatTimes)
                    {
                        repeatElement = current;
                    }
                    else
                    {
                        repeatElement = -100000;
                    }
                }
            }
            
            return repeatElement;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3, 3};
            var nums1 = Program.RepeatedNTimes(nums);

        }
    }
}
