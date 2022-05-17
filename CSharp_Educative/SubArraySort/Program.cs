using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySort
{
    class Program
    {
        public static int[] SubarraySort(int[] array)
        {
            if (array.Length < 2) return new int[] { -1, -1 };

            int minOutOfBound = Int32.MaxValue;
            int maxOutOfBound = Int32.MinValue;


            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];

                if (OutOfBound(num, i, array))
                {
                    minOutOfBound = Math.Min(minOutOfBound, num);
                    maxOutOfBound = Math.Max(maxOutOfBound, num);
                }

            }

            if (maxOutOfBound == Int32.MinValue) return new int[] { -1, -1 };

            int startIdx = 0;

            while (startIdx < array.Length && array[startIdx] < minOutOfBound)
            {
                startIdx++;
            }

            int endIdx = array.Length-1;
            while (endIdx >= 0 && array[endIdx] > maxOutOfBound)
            {
                endIdx--;
            }

            return new int[] { startIdx, endIdx };

        }

        public static bool OutOfBound(int num, int i, int[] array)
        {
            if (i == 0) return num > array[i + 1];
            if (i == array.Length - 1) return num < array[i - 1];

            return num > array[i + 1] || num < array[i - 1];
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 4, 7, 10, 11, 7, 12, 7, 7, 16, 18, 19 };
            int[] result = Program.SubarraySort(array);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
