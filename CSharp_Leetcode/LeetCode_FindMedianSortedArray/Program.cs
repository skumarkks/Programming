using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_FindMedianSortedArray
{
    class Program
    {
        public static double FindMedianSortedArrays(int[] a, int[] b)
        {
            var m = a.Length;
            var n = b.Length;
            if (m > n)
            { // to ensure m<=n
                var temp = a; a = b; b = temp;
                var tmp = m; m = n; n = tmp;
            }
            int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
            while (iMin <= iMax)
            {
                var i = (iMin + iMax) / 2;
                var j = halfLen - i;
                if (i < iMax && b[j - 1] > a[i])
                {
                    iMin = iMin + 1; // i is too small
                }
                else if (i > iMin && a[i - 1] > b[j])
                {
                    iMax = iMax - 1; // i is too big
                }
                else
                { // i is perfect
                    var maxLeft = 0;
                    if (i == 0) { maxLeft = b[j - 1]; }
                    else if (j == 0) { maxLeft = a[i - 1]; }
                    else { maxLeft = Math.Max(a[i - 1], b[j - 1]); }
                    if ((m + n) % 2 == 1) { return maxLeft; }

                    var minRight = 0;
                    if (i == m) { minRight = b[j]; }
                    else if (j == n) { minRight = a[i]; }
                    else { minRight = Math.Min(b[j], a[i]); }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;
        }
        static void Main(string[] args)
        {
            int[] a = {2, 6, 8};
            int[] b = {1, 3, 4,5};
            double median = Program.FindMedianSortedArrays(a, b);
            Console.WriteLine(median);
        }
    }
}
