using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_MonotonicArray_896
{
    class Program
    {
        /*public static bool IsMonotonic(int[] A)
        {
            bool isMonotonic = false;

            //get the length of the array
            int length = A.Length;

            if (length == 0)
                return false;

            if (length == 1)
                return true;

            if (length == 2)
            {
                if (A[0] <= A[1])
                {
                    return true;
                }
                else if(A[0] >= A[1])
                {
                    return true;
                }

                return false;
            }

            bool isIncreseing= false;
            bool isEqual = false;

            //get the first element and second element and determine increasing or decreasing
            int j;
            for (j = 0; j < length-1; j++)
            {
                if (A[j] == A[j + 1])
                {
                    isEqual = true;
                }
                else if (A[j] < A[j + 1])
                {
                    if (j == 0)
                        j = 1;
                   
                    isIncreseing = true;
                    break;
                }
                else if (A[j] > A[j + 1])
                {
                    if (j == 0)
                        j = 1;
                    isIncreseing = false;
                    break;
                }

            }

            if (isEqual == true && j == length - 1)
                return true;

            if (isIncreseing)
            {
                //if the array if increase a[i-1] < a[i] < a[i+1]
                for (int i = j; i < length - 1; i++)
                {
                    if ((A[i - 1] <= A[i]) && (A[i] <= A[i + 1]))
                    {
                        isMonotonic = true;
                    }
                    else
                    {
                        isMonotonic = false;
                        break;
                    }
                }
            }
            else
            {
                //if the array if decresing a[i-1] > a[i] > a[i+1]
                for (int i = j; i < length - 1; i++)
                {
                    if ((A[i - 1] >= A[i]) && (A[i] >= A[i + 1]))
                    {
                        isMonotonic = true;
                    }
                    else
                    {
                        isMonotonic = false;
                        break;
                    }
                }

            }
            return isMonotonic;
        }*/

        public static bool IsMonotonic(int[] A)
        {
            bool increaseing = true;
            bool decreasing = true;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < A[i + 1])
                    decreasing = false;
                if (A[i] > A[i + 1])
                    increaseing = false;
            }

            return increaseing || decreasing;
        }
        static void Main(string[] args)
        {
            int[] a = {2,2,2};
            bool isMonotonic = Program.IsMonotonic(a);
            Console.WriteLine(isMonotonic);
        }
    }
}
