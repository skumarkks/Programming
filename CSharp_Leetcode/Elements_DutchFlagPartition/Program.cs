using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements_DutchFlagPartition
{
    internal class Program
    {
        private static int[] DutchFlagPartition(int pivotIndex, int[] a)
        {
            var pivot = a[pivotIndex];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < pivot)
                    {
                        Swap(a, i,j);
                        break;
                    }
                }
            }

            for(int i = a.Length; i <= 0; i--)
            {
                for (int j = i - 1; j <= 0; j--)
                {
                    if (a[j] > pivot)
                    {
                        Swap(a, i, j);
                        break;
                    }
                }
            }

            return a;
        }

        private static int[] DutchFlagPartition2Pass(int pivotIndex, int[] a)
        {
            var pivot = a[pivotIndex - 1];
            int small = 0;
            int big = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < pivot)
                {
                    Swap(a, i, small++);
                    //small++;
                }
            }
            for(int i = a.Length-1; i >= 0; i--)
            {
                if (a[i] > pivot)
                {
                    Swap(a, i, big--);
                    //small++;
                }
            }

            return a;
        }

        private static int[] DutchFlagPartition1Pass(int pivotIndex, int[] a)
        {
            var pivot = a[pivotIndex - 1];

            int equal = 0;
            int small = 0;
            int large = a.Length - 1;

            while (equal < large)
            {
                if (a[equal] < pivot)
                {
                    Swap(a, equal++, small++);
                }
                else if (a[equal] == pivot)
                {
                    equal++;
                }
                else
                {
                    Swap(a,equal,large--);
                }
            }

            return a;
        }

        private static void Swap(int[] a, int i, int j)
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        private static void Main(string[] args)
        {
            //int[] a = {2, 6, 8, 1, 3, 9, 7};

            int[] a = {1, 4, 2, 4, 2, 4, 1, 2, 4, 1, 2, 2, 2, 2, 4, 1, 4, 4, 4};

            //int[]  a = { 4, 9, 4, 4, 1, 9, 4, 4, 9, 4, 4, 1, 4 };

            //var b = DutchFlagPartition(1, a);

            //var b = DutchFlagPartition2Pass(7, a);

            var b = DutchFlagPartition1Pass(4, a);

            foreach (var b1 in b)
            {
                Console.Write("{0},", b1);
            }
        }
    }
}
