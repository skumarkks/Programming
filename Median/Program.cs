using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    class Program
    {
        // Time Complexity (O(log(m+n)) and Space Complexity (O(n))
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nl1 = nums1.Length;
            int nl2 = nums2.Length;
            
            var mergeArray = MergeArray(nums1, nums2);

            int medianIdx = -1;

            if ((nl1 + nl2) % 2 != 0)
            {
                medianIdx = (nl1 + nl2) / 2;
                return mergeArray[medianIdx];
            }
            else
            {
                medianIdx = (nl1 + nl2) / 2;
                return ((double)mergeArray[medianIdx-1] + (double)mergeArray[medianIdx]) / 2;
            }
        }

        private static int[] MergeArray(int[] nums1, int[] nums2)
        {
            int nl1 = nums1.Length;
            int nl2 = nums2.Length;

            int[] mergeArray = new int[nl1 + nl2];

            int[] arr1 = null;
            int[] arr2 = null;

            if (nl1 <= nl2)
            {
                arr1 = nums1;
                arr2 = nums2;
            }
            else
            {
                arr1 = nums2;
                arr2 = nums1;
            }

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    mergeArray[k++] = arr1[i];
                    i++;
                }
                else
                {
                    mergeArray[k++] = arr2[j];
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                mergeArray[k++] = arr1[i];
                i++;
            }

            while (j < arr2.Length)
            {
                mergeArray[k++] = arr2[j];
                j++;
            }

            return mergeArray;
        }

        static void Main(string[] args)
        {
            int[] nums1 = new int[] {100001};
            int[] nums2 = new int[] {100000};

            double  median = Program.FindMedianSortedArrays(nums1, nums2);

        }
    }
}
